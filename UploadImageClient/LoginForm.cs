﻿using GeekoUploadImage;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UploadImageClient.pojo;
using UploadImageClient.utils;

namespace UploadImageClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitFormLayout();
            InitTime();
            CustomizeTabControlAppearance();

        }
        private string service_address = ServiceAddress.service_address;
        //ConfigUtils.getConfigByKey("ServiceAddress");
        private delegate void MyDelegateUI();
        private Form openForm;
        private int countSms = 120;
        public void setForm(Form fForm)
        {
            openForm = fForm;
        }

        #region time 计时器
        public void InitTime()
        {

            smsTime.Interval = 1000;
            smsTime.Tick += smsTimer_Tick;
        }
        #endregion



        #region init form layout

        private void CustomizeTabControlAppearance()
        {
            tabControl1.Padding = new Point(0, 0);
            tabControl1.ItemSize = new Size(tabControl1.Width / 2 - 2, tabControl1.ItemSize.Height + 10);
        }

        public void InitFormLayout()
        {

            this.lineShape1.X1 = this.txtuser.Location.X;
            this.lineShape1.X2 = this.txtuser.Location.X + this.txtuser.Size.Width;
            this.lineShape1.Y1 = this.txtuser.Location.Y + this.txtuser.Size.Height + 10;
            this.lineShape1.Y2 = this.txtuser.Location.Y + this.txtuser.Size.Height + 10;

            this.lineShape2.X1 = this.txtsms.Location.X;
            this.lineShape2.X2 = this.txtsms.Location.X + this.txtsms.Size.Width;
            this.lineShape2.Y1 = this.txtsms.Location.Y + this.txtsms.Size.Height + 10;
            this.lineShape2.Y2 = this.txtsms.Location.Y + this.txtsms.Size.Height + 10;

            this.lineShape3.X1 = this.txtuser2.Location.X;
            this.lineShape3.X2 = this.txtuser2.Location.X + this.txtuser2.Size.Width;
            this.lineShape3.Y1 = this.txtuser2.Location.Y + this.txtuser2.Size.Height + 10;
            this.lineShape3.Y2 = this.txtuser2.Location.Y + this.txtuser2.Size.Height + 10;

            this.lineShape4.X1 = this.txtpass.Location.X;
            this.lineShape4.X2 = this.txtpass.Location.X + this.txtpass.Size.Width;
            this.lineShape4.Y1 = this.txtpass.Location.Y + this.txtpass.Size.Height + 10;
            this.lineShape4.Y2 = this.txtpass.Location.Y + this.txtpass.Size.Height + 10;


            this.sendSms.Location = new Point(this.txtsms.Location.X + this.txtsms.Size.Width + 10, this.txtsms.Location.Y);
        }

        #endregion

        #region Drag
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region 
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "用户名/手机号")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "用户名/手机号";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "密码")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "密码";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }


        private void txtsms_Enter(object sender, EventArgs e)
        {
            if (txtsms.Text == "验证码")
            {
                txtsms.Text = "";
                txtsms.ForeColor = Color.LightGray;
            }
        }


        private void txtsms_Leave(object sender, EventArgs e)
        {
            if (txtsms.Text == "")
            {
                txtsms.Text = "验证码";
                txtsms.ForeColor = Color.Silver;
            }
        }

        private void txtuser2_Enter(object sender, EventArgs e)
        {
            if (txtuser2.Text == "用户名")
            {
                txtuser2.Text = "";
                txtuser2.ForeColor = Color.Silver;
            }
        }

        private void txtuser2_Leave(object sender, EventArgs e)
        {
            if (txtuser2.Text == "")
            {
                txtuser2.Text = "用户名";
                txtuser2.ForeColor = Color.Silver;
            }
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "smsloginpage")
            {
                if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
                {
                    this.btnlogin_Click(sender, e);//触发button事件  
                }
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "passloginpage")
            {
                if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
                {
                    this.passlogin_Click(sender, e);//触发button事件  
                }
            }

        }

        private void txtsms_KeyDown(object sender, KeyEventArgs e)
        {

            if (tabControl1.SelectedTab.Name == "smsloginpage")
            {
                if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
                {
                    this.btnlogin_Click(sender, e);//触发button事件  
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.updateVersionWorker.RunWorkerAsync();
        }


        private void txtuser2_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "passloginpage")
            {
                if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
                {
                    this.passlogin_Click(sender, e);//触发button事件  
                }
            }
        }


        #endregion

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region table 1
        private void sendSms_Click(object sender, EventArgs e)
        {

            if (txtuser.Text.Trim() == "" || txtuser.Text.Trim() == "用户名/手机号")
            {
                MessageBox.Show("用户名/手机号不可以为空！", "温馨提示");
                txtuser.Focus();
            }
            else
            {
                sendSms.Enabled = false;

                var client = new RestClient(service_address + "/login/get-client-identifying-code");//api地址
                string resources = null;
                var request = new RestRequest(resources, Method.Post);//post提交方式
                request.AddParameter("loginNameOrPhoneNumber", txtuser.Text.Trim());

                try
                {
                    var response = client.Execute(request);//返回信息

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        try
                        {
                            Dictionary<string, object> result = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content);
                            if (Boolean.Parse(result["success"].ToString()) == true)
                            {
                                MessageBox.Show("验证码已发送，注意查收！");
                                smsTime.Start();
                            }
                            else
                            {
                                MessageBox.Show("错误原因：" + result["result"].ToString());
                                sendSms.Enabled = true;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("发送验证码失败！请检查网络，或者更换登陆方式！");
                            sendSms.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("发送验证码失败！请检查网络，或者更换登陆方式！");
                        sendSms.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发送验证码失败！请检查网络，或者更换登陆方式！");
                    sendSms.Enabled = true;
                }

            }

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (txtuser.Text.Trim() == "" || txtuser.Text.Trim() == "用户名/手机号")
            {
                MessageBox.Show("用户名/手机号不可以为空！", "温馨提示");
                txtuser.Focus();
            }
            else if (txtsms.Text.Trim() == "" || txtsms.Text.Trim() == "验证码")
            {
                MessageBox.Show("验证码不可以为空！", "温馨提示");
                txtsms.Focus();
            }
            else
            {
                btnlogin.Enabled = false;
                Task.Factory.StartNew(() =>
                {
                    string UserName = this.txtuser.Text;
                    string Sms = this.txtsms.Text;
                    string errorMessage = "";

                    try
                    {
                        Dictionary<string, object> user = loginWithSms(UserName, Sms, ref errorMessage);//登录    返回用户ID
                        if (user != null)
                        {
                            MyDelegateUI mainFormDelegate = delegate
                            {
                                // 创建主窗体
                                MainForm mainForm = (MainForm)openForm;
                                if (openForm == null)
                                {
                                    mainForm = new MainForm();
                                }
                                User userData = JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(user["result"]));
                                mainForm.SetUserData(userData, this); // 调用方法传递数据
                                passlogin.Visible = true;
                                // 显示主窗体
                                mainForm.Show();
                                // 关闭当前登录窗体
                                this.Hide();
                            };
                            this.Invoke(mainFormDelegate);
                        }
                        else
                        {
                            MessageBox.Show($"登录失败,错误原因： {errorMessage}");
                        }
                    }
                    catch { }

                    MyDelegateUI btnloginDelegate = delegate
                    {
                        btnlogin.Enabled = true;
                        txtsms.Text = "";
                        sendSms.Enabled = true;
                        sendSms.Text = "发送验证码";
                        countSms = 120;
                        smsTime.Stop();
                    };
                    this.btnlogin.Invoke(btnloginDelegate);
                });
            }
        }

        public Dictionary<string, object> loginWithSms(string userName, string _password, ref string errorMessage)
        {
            if (service_address == null)
            {

                errorMessage = "无法连接到服务器。请稍后重试！!!";
                return null;
            }
            else
            {
                var client = new RestClient(service_address + "/login/login-with-identifying-code");//api地址
                string resources = null;
                var request = new RestRequest(resources, Method.Post);//post提交方式


                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

                request.AddParameter("systemCode", "4");
                request.AddParameter("loginNameOrPhoneNumber", userName);
                request.AddParameter("code", _password);

                var response = client.Execute(request);//返回信息

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    try
                    {
                        Dictionary<string, object> result = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content);
                        if (Boolean.Parse(result["success"].ToString()) == true)
                        {
                            return result;
                        }
                        else
                        {
                            errorMessage = result["result"].ToString();

                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        var result = JsonConvert.DeserializeObject<dynamic>(response.Content);

                        errorMessage = result.result;

                        return null;
                    }
                }
                else
                {
                    errorMessage = "无法连接到服务器。请稍后重试！";
                    if (response.Content != null)
                    {
                        try
                        {
                            var result = JsonConvert.DeserializeObject<dynamic>(response.Content);

                            if (result != null)
                            {
                                errorMessage = result.error.details;
                            }
                        }
                        catch
                        {
                        }
                    }
                    return null;
                }
            }


        }

        #endregion


        #region table 2

        private void passlogin_Click(object sender, EventArgs e)
        {
            //// 创建主窗体
            //MainForm mainForm = new MainForm();

            //// 显示主窗体
            //mainForm.Show();
            //// 关闭当前登录窗体
            //this.Hide();


            if (txtuser2.Text.Trim() == "" || txtuser2.Text.Trim() == "用户名")
            {
                MessageBox.Show("用户名不可以为空！", "温馨提示");
                txtuser2.Focus();

            }
            else if (txtpass.Text.Trim() == "" || txtpass.Text.Trim() == "密码")
            {
                MessageBox.Show("密码不可以为空！", "温馨提示");
                txtpass.Focus();
            }
            else
            {
                passlogin.Enabled = false;

                Task.Factory.StartNew(() =>
                {
                    string UserName = this.txtuser2.Text;
                    string Password = this.txtpass.Text;
                    string errorMessage = "";

                    try
                    {
                        Dictionary<string, string> device = getDevice(ref errorMessage);
                        if (device != null)
                        {
                            Dictionary<string, object> user = login(UserName, Password, device, ref errorMessage);//登录    返回用户ID
                            if (user != null)
                            {
                                MyDelegateUI mainFormDelegate = delegate
                                {
                                    // 创建主窗体
                                    MainForm mainForm = (MainForm)openForm;
                                    if (openForm == null)
                                    {
                                        mainForm = new MainForm();
                                    }
                                    User userData = JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(user["result"]));
                                    mainForm.SetUserData(userData, this); // 调用方法传递数据
                                    passlogin.Visible = true;
                                    // 显示主窗体
                                    mainForm.Show();
                                    // 关闭当前登录窗体
                                    this.Hide();
                                };
                                this.Invoke(mainFormDelegate);
                            }
                            else
                            {
                                MessageBox.Show($"登录失败,错误原因： {errorMessage}");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"登录失败!   错误原因： {errorMessage}");
                        }
                    }
                    catch { }

                    MyDelegateUI btnloginDelegate = delegate
                    {
                        passlogin.Enabled = true;
                        txtpass.Text = "";
                    };
                    this.btnlogin.Invoke(btnloginDelegate);
                });
            }
        }

        public Dictionary<string, string> getDevice(ref string errorMessage)
        {
            var client = new RestClient("http://127.0.0.1:50500/user-verification/");//api地址
            var response = client.Execute(new RestRequest());//返回信息
            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {

                    return JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                }
                catch (Exception ex)
                {
                    errorMessage = "获取加密狗信息失败！";
                    return null;
                }
            }
            else
            {
                errorMessage = "无法连接到加密狗，请检查加密狗是否打开。";
                return null;
            }
        }

        public Dictionary<string, object> login(string userName, string _password, Dictionary<string, string> key, ref string errorMessage)
        {
            if (service_address == null)
            {

                errorMessage = "无法连接到服务器。请稍后重试！!!";
                return null;
            }
            var client = new RestClient(service_address + "/login/login-with-password");//api地址
            string resources = null;
            var request = new RestRequest(resources, Method.Post);//post提交方式
                                                                  //request.AddHeader("Content-type", "application/json");

            //request.AddJsonBody(new
            //{
            //    systemCode = "1",
            //    username = userName,
            //    password = _password,
            //    deviceId = key["deviceId"],
            //    secureCode = key["secureCode"]

            //});


            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            request.AddParameter("systemCode", "4");
            request.AddParameter("username", userName);
            request.AddParameter("password", _password);
            request.AddParameter("deviceId", key["deviceId"]);
            request.AddParameter("secureCode", key["secureCode"]);

            var response = client.Execute(request);//返回信息

            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    Dictionary<string, object> result = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content);
                    if (Boolean.Parse(result["success"].ToString()) == true)
                    {
                        return result;
                    }
                    else
                    {
                        errorMessage = result["result"].ToString();

                        return null;
                    }


                }
                catch (Exception ex)
                {
                    var result = JsonConvert.DeserializeObject<dynamic>(response.Content);

                    errorMessage = result.result;

                    return null;
                }

            }
            else
            {
                errorMessage = "无法连接到服务器。请稍后重试！";
                if (response.Content != null)
                {
                    try
                    {
                        var result = JsonConvert.DeserializeObject<dynamic>(response.Content);

                        if (result != null)
                        {
                            errorMessage = result.error.details;
                        }

                    }
                    catch
                    {
                    }

                }


                return null;
            }

        }

        #endregion

        private void updateVersionWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            e.Result = CheckWinformVersion();
        }

        public bool CheckWinformVersion()
        {
            try
            {
                String version = Application.ProductVersion.ToString();

                var client = new RestClient(service_address + "/api/winfrom-download/is-update-client");//api地址
                string resources = null;
                var request = new RestRequest(resources, Method.Post);//post提交方式
                request.AddParameter("version", version);

                var response = client.Execute(request);//返回信息

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    try
                    {
                        Dictionary<string, object> result = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content);
                        if (Boolean.Parse(result["success"].ToString()) == true)
                        {
                            string data = result["result"].ToString();
                            if (data.Equals("false") || data.Equals("False"))
                            {
                                return false;
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            catch
            {
                //MessageBox.Show("程序版本获取失败，或者联系技术人员获取新版本！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            }
            return true;
        }

        private void updateVersionWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                // 处理异常
                MessageBox.Show("后台任务发生错误：" + e.Error.Message);
            }
            else if (e.Result != null && !(bool)e.Result)
            {
                // 显示消息框
                MessageBox.Show("检查到程序有新版，请下载最新版使用!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                Application.Exit();
            }

        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            txtuser.Focus();
        }

        private void smsTimer_Tick(object send, EventArgs e)
        {
            countSms--;
            sendSms.Text = "已发送(" + countSms + "s)";
            if (countSms <= 0)
            {
                sendSms.Enabled = true;
                sendSms.Text = "发送验证码";
                countSms = 120;
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }
    }
}
