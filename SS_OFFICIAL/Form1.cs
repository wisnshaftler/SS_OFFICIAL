using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Management;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SS_OFFICIAL
{
    public partial class Form1 : Form
    {
        //golabl email and password
        public string email, password, userID;
        public Form1()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Please wait....";
            email = txtemail.Text;
            password = txtpassword.Text;

            //hash the password 
            byte[] shaByte = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder bulder = new StringBuilder();
            for (int i = 0; i < shaByte.Length; i++)
            {
                bulder.Append(shaByte[i].ToString("x2"));
            }
            bulder.ToString();

            //set password
            password = bulder.ToString();

            loginData logdata = new loginData();
            logdata.email = email;
            logdata.password = password;
            var jsonlogdata = JsonConvert.SerializeObject(logdata);
            StringContent data = new StringContent(jsonlogdata, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync("login", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    String result = await response.Content.ReadAsStringAsync();
                    JObject jsonReply = JObject.Parse(result);

                    String status = (string)jsonReply["status"];

                    if (status == "0")
                    {
                        MessageBox.Show("Email or password is incorrect", "Ops!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }

                    JArray responseData = (JArray)jsonReply["data"];

                    //create folder for store defalts.
                    Directory.CreateDirectory(@"c:\silicon_society");
                    Directory.CreateDirectory(@"c:\silicon_society\software");
                    Directory.CreateDirectory(@"c:\silicon_society\storage");
                    cmdRun cmd = new cmdRun();

                    string uuid = await cmd.getCMD("wmic csproduct get uuid", 6);

                    uuidSearch uuidSearch = new uuidSearch();
                    uuidSearch.email = email;
                    uuidSearch.password = password;
                    uuidSearch.uuid = uuid.Trim();


                    var uuidSearchData = JsonConvert.SerializeObject(uuidSearch);
                    StringContent uuidPostData = new StringContent(uuidSearchData, Encoding.UTF8, "application/json");

                    using (HttpResponseMessage responses = await ApiHelper.ApiClient.PostAsync("uuidSearch", uuidPostData))
                    {
                        if (responses.IsSuccessStatusCode)
                        {
                            result = await responses.Content.ReadAsStringAsync();
                            jsonReply = JObject.Parse(result);

                            JArray status1 = (JArray)jsonReply["data"];

                            btnRegister.Enabled = false;
                            if (status1.Count == 0)
                            {
                                uuid = "";
                                btnRegister.Enabled = true;
                            }

                            userID = responseData[0]["_id"].ToString();

                            JObject defaultData = new JObject(
                                new JProperty("user_id", responseData[0]["_id"]),
                                new JProperty("user_email", email),
                                new JProperty("UUID", uuid.Trim())
                                );

                            File.WriteAllText(@"c:\silicon_society\defaultData.json", defaultData.ToString());
                            lblStatus.Text = "Sign in sucessfull";

                            MessageBox.Show("Sucess", "Sign in successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (status1.Count == 0)
                            {
                                foreach(Control tbc in tabmain.Controls)
                                {
                                    if(tbc.Name != "tabDeviceReg")
                                    {
                                        tbc.Enabled = false;
                                    }
                                }
                                MessageBox.Show("This device is not regiresterd yet. Please register this device to continue. All other" +
                                    "features are available after this device registerd", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }

                            logingrp.Visible = false;
                            tabmain.Visible = true;

                            status1 = null;
                            defaultData = null;
                        }
                    }
                    status = null;
                    data = null;
                    cmd = null;
                    result = null;
                    uuid = null;
                    bulder = null;
                }
            }
        }
        public class loginData
        {
            public String email { get; set; }
            public String password { get; set; }
        }

        private async void btnLoadDevice_Click(object sender, EventArgs e)
        {
            tabmain.UseWaitCursor = true;
            lblStatus.Text = "Processing...";

            cmdRun cmd = new cmdRun();

            string uuid = await cmd.getCMD("wmic csproduct get uuid", 6);

            uuidSearch uuidSearch = new uuidSearch();
            uuidSearch.email = email;
            uuidSearch.password = password;
            uuidSearch.uuid = uuid.Trim();

            string processorName = await cmd.getCMD("wmic cpu get name", 6);
            string[] processorSlice;
            if (processorName.Contains("AMD"))
            {
                processorSlice = processorName.Split(' ');
                processorName = processorSlice[1] + " " + processorSlice[2] + " " + processorSlice[3];
            }
            if (processorName.Contains("Intel"))
            {
                processorSlice = processorName.Split(' ');
                processorName = processorSlice[2];
            }

            processorSearch processorSearch = new processorSearch();
            processorSearch.email = email;
            processorSearch.password = password;
            processorSearch.processor = processorName.ToLower();

            var jsonlogdata = JsonConvert.SerializeObject(processorSearch);
            StringContent data = new StringContent(jsonlogdata, Encoding.UTF8, "application/json");

            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync("processorList", data))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cant connect to server.Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Text = "Error. Please try again";
                        return;
                    }
                    else
                    {
                        String result = await response.Content.ReadAsStringAsync();
                        JObject jsonReply = JObject.Parse(result);

                        string status = (string)jsonReply["status"];
                        if (status == "0")
                        {
                            string errorMessage = (string)jsonReply["msg"];
                            MessageBox.Show("Error: Server say :-" + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lblStatus.Text = "Welcome.";
                            return;
                        }
                        else
                        {
                            JArray processorArray = (JArray)jsonReply["data"];
                            foreach (JObject processor in processorArray)
                            {
                                cmbCPU.Items.Add(processor.GetValue("Processor").ToString());
                            }

                            string os = await cmd.getCMD("wmic os get name", 6);

                            os = os.ToString().Split('|')[0].ToString();

                            if (os.Contains("10"))
                            {
                                lblOS.Text = "windows 10";
                            }
                            else
                            if (os.Contains("7"))
                            {
                                lblOS.Text = "windows 7";
                            }
                            else
                           if (os.Contains("8"))
                            {
                                lblOS.Text = "windows 8";
                            }
                            else
                           if (os.Contains("11"))
                            {
                                lblOS.Text = "windows 11";
                            }
                            else
                            {
                                lblOS.Text = "windows xp";
                            }

                            runPowerShell powerShell = new runPowerShell();
                            List<string> ramSize=await powerShell.runCommand("Get-WmiObject -Class Win32_ComputerSystem | select TotalPhysicalMemory");
                            ulong ramValue = ulong.Parse( new Regex(@"\d+").Match(ramSize[0]).Value.Trim());
                            ramValue = (ramValue/2)/ 1000000000;
                            ramCapacity.Maximum = ramValue;

                            tabmain.UseWaitCursor = false;
                            lblStatus.Text = "Done";
                            MessageBox.Show("Done loading data. Please fill and press the register button", "Data loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to server is interupted. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        public class uuidSearch
        {
            public String uuid { get; set; }
            public String email { get; set; }
            public String password { get; set; }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                tabmain.UseWaitCursor = true;

                if(txtpcname.Text.Trim() == "")
                {
                    MessageBox.Show("Cant be PC name empty.", "Dont keep empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabmain.UseWaitCursor = false;
                    return;
                }
                if(cmbCPU.SelectedIndex == -1)
                {
                    MessageBox.Show("Cant be PC processor empty.", "Dont keep empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabmain.UseWaitCursor = false;
                    return;
                }

                string pcname = txtpcname.Text;
                decimal network = networkCapacity.Value;
                decimal ram = ramCapacity.Value;
                decimal storage = storageCapacity.Value;
                string cpuName = cmbCPU.SelectedItem.ToString();
                string osName = lblOS.Text;

                if(network == 0|| ram == 0 || storage ==0)
                {
                    MessageBox.Show("Cant use 0 values.", "Dont keep invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabmain.UseWaitCursor = false;
                    return;
                }

                cmdRun cmd = new cmdRun();

                string uuid = await cmd.getCMD("wmic csproduct get uuid", 6);

                uuidSearch uuidSearch = new uuidSearch();
                uuidSearch.email = email;
                uuidSearch.password = password;
                uuidSearch.uuid = uuid.Trim();

                //creating object for send device registration data to server
                newDevice device = new newDevice();
                device.email = email;
                device.password = password;
                device.cpuName = cpuName;
                device.osName = osName;
                device.pcname = pcname;
                device.UUID = uuid.Trim();
                device.ram = ram;
                device.storage = storage;
                device.network = network;

                var jsonconvert = JsonConvert.SerializeObject(device);
                StringContent jasonData = new StringContent(jsonconvert, Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync("newDevice", jasonData))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cant connect to server.Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Text = "Error. Please try again";
                        tabmain.UseWaitCursor = false;
                        return;
                    }

                    String result = await response.Content.ReadAsStringAsync();
                    JObject jsonReply = JObject.Parse(result);

                    string status = (string)jsonReply["status"];

                    if(status == "0")
                    {
                        string errorMessage = (string)jsonReply["msg"];
                        MessageBox.Show("Error: Server say :-" + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Text = "Welcome.";
                        tabmain.UseWaitCursor = false;
                        return;
                    }
                    if(status == "1")
                    {
                        JObject defaultData = new JObject(
                                new JProperty("user_id", userID),
                                new JProperty("user_email", email),
                                new JProperty("UUID", uuid.Trim())
                                );

                        File.WriteAllText(@"c:\silicon_society\defaultData.json", defaultData.ToString());

                        MessageBox.Show("Registration complete", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabmain.UseWaitCursor = false;
                        foreach (Control tbc in tabmain.Controls)
                        {
                            tbc.Enabled = true;
                        }
                        return;
                    }
                    lblStatus.Text = "Successfully added this device";

                    foreach (Control tbc in tabmain.Controls)
                    {
                        tbc.Enabled = true;
                    }

                    tabmain.UseWaitCursor = false;
                    btnRegister.Enabled = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to server is interupted. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabmain.UseWaitCursor = false;
            }
        }

        public class processorSearch
        {
            public String email { get; set; }
            public String password { get; set; }
            public String processor { get; set; }
        }

        public async void getProject()
        {
            try
            {
                cmdRun cmd = new cmdRun();

                string uuid = await cmd.getCMD("wmic csproduct get uuid", 6);

                uuidSearch uuidSearch = new uuidSearch();
                uuidSearch.email = email;
                uuidSearch.password = password;
                uuidSearch.uuid = uuid.Trim();

                JObject projectSearch = new JObject(
                    new JProperty("UUID", uuid),
                    new JProperty("email", email),
                    new JProperty("password", password)
                    );

                var jsonconvert = JsonConvert.SerializeObject(projectSearch);
                StringContent jasonData = new StringContent(jsonconvert, Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync("projectSearch", jasonData))
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cant connect to server.Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Text = "Error. Please try again";
                        tabmain.UseWaitCursor = false;
                        return;
                    }
                    //get all project data
                    String result = await response.Content.ReadAsStringAsync();
                    JObject jsonReply = JObject.Parse(result);

                    string status = (string)jsonReply["status"];
                    if (status == "0")
                    {
                        string errorMessage = (string)jsonReply["msg"];
                        MessageBox.Show("Error: Server say :-" + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Text = "Welcome.";
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again");
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class newDevice
        {
            public String email { get; set; }
            public String password { get; set; }
            public String pcname { get; set; }
            public String cpuName { get; set; }
            public String osName { get; set; }
            public String UUID { get; set; }
            public decimal network { get; set; }
            public decimal ram { get; set; }
            public decimal storage { get; set; }
            

        }
        
    }
}
