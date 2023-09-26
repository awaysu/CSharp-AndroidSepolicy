/*
 * Created by SharpDevelop.
 * User: Awaysu
 * Date: 05/17/2022
 * Time: PM 03:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;

namespace convert_avc_to_sepolicy
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	
		private int[] arrIoctrlVal = new int[192]
		{
			35076, 35077, 35078, 35079, 35083, 35084, 35085, 35088, 35089, 35090,
			35091, 35092, 35093, 35094, 35095, 35096, 35097, 35098, 35099, 35100,
			35101, 35102, 35103, 35104, 35105, 35106, 35107, 35108, 35109, 35110,
			35111, 35113, 35120, 35121, 35122, 35123, 35124, 35125, 35126, 35127,
			35128, 35129, 35136, 35137, 35138, 35139, 35142, 35143, 35144, 35145,
			35146, 35147, 35155, 35156, 35157, 35168, 35169, 35170, 35184, 35185,
			35200, 35201, 35202, 35203, 35216, 35217, 35218, 35219, 35220, 35221,
			35232, 35233, 35234, 35235, 35248, 35249, 35296, 35297, 35298, 35299,
			35300, 35301, 35302, 35303, 35304, 35305, 35306, 35307, 35308, 35309,
			35310, 35311, 35312, 35313, 35314, 35315, 35316, 35317, 35318, 35319,
			35320, 35321, 35322, 35323, 35324, 35325, 35326, 35327, 35584, 35584,
			35585, 35586, 35587, 35588, 35589, 35590, 35591, 35592, 35593, 35594,
			35595, 35596, 35597, 35598, 35599, 35600, 35601, 35602, 35603, 35604,
			35605, 35606, 35607, 35608, 35609, 35610, 35611, 35612, 35613, 35616,
			35617, 35618, 35619, 35620, 35621, 35622, 35623, 35624, 35625, 35626,
			35627, 35628, 35629, 35632, 35633, 35634, 35635, 35636, 35637, 35638,
			35808, 35809, 35810, 35811, 35812, 35813, 35814, 35815, 35816, 35817,
			35818, 35819, 35820, 35821, 35822, 35823, 35824, 35825, 35826, 35827,
			35828, 35829, 35830, 35831, 35832, 35833, 35834, 35835, 35836, 35837,
			35838, 35839
		};

		private string[] arrIoctrlText = new string[192]
		{
			"SIOCGPGRP", "SIOCATMARK", "SIOCGSTAMP", "SIOCGSTAMPNS", "SIOCADDRT", "SIOCDELRT", "SIOCRTMSG", "SIOCGIFNAME", "SIOCSIFLINK", "SIOCGIFCONF",
			"SIOCGIFFLAGS", "SIOCSIFFLAGS", "SIOCGIFADDR", "SIOCSIFADDR", "SIOCGIFDSTADDR", "SIOCSIFDSTADDR", "SIOCGIFBRDADDR", "SIOCSIFBRDADDR", "SIOCGIFNETMASK", "SIOCSIFNETMASK",
			"SIOCGIFMETRIC", "SIOCSIFMETRIC", "SIOCGIFMEM", "SIOCSIFMEM", "SIOCGIFMTU", "SIOCSIFMTU", "SIOCSIFNAME", "SIOCSIFHWADDR", "SIOCGIFENCAP", "SIOCSIFENCAP",
			"SIOCGIFHWADDR", "SIOCGIFSLAVE", "SIOCSIFSLAVE", "SIOCADDMULTI", "SIOCDELMULTI", "SIOCGIFINDEX", "SIOCSIFPFLAGS", "SIOCGIFPFLAGS", "SIOCDIFADDR", "SIOCSIFHWBROADCAST",
			"SIOCGIFCOUNT", "SIOCKILLADDR", "SIOCGIFBR", "SIOCSIFBR", "SIOCGIFTXQLEN", "SIOCSIFTXQLEN", "SIOCETHTOOL", "SIOCGMIIPHY", "SIOCGMIIREG", "SIOCSMIIREG",
			"SIOCWANDEV", "SIOCOUTQNSD", "SIOCDARP", "SIOCGARP", "SIOCSARP", "SIOCDRARP", "SIOCGRARP", "SIOCSRARP", "SIOCGIFMAP", "SIOCSIFMAP",
			"SIOCADDDLCI", "SIOCDELDLCI", "SIOCGIFVLAN", "SIOCSIFVLAN", "SIOCBONDENSLAVE", "SIOCBONDRELEASE", "SIOCBONDSETHWADDR", "SIOCBONDSLAVEINFOQUERY", "SIOCBONDINFOQUERY", "SIOCBONDCHANGEACTIVE",
			"SIOCBRADDBR", "SIOCBRDELBR", "SIOCBRADDIF", "SIOCBRDELIF", "SIOCSHWTSTAMP", "SIOCGHWTSTAMP", "SIOCPROTOPRIVATE", "SIOCPROTOPRIVATE_1", "SIOCPROTOPRIVATE_2", "SIOCPROTOPRIVATE_3",
			"SIOCPROTOPRIVATE_4", "SIOCPROTOPRIVATE_5", "SIOCPROTOPRIVATE_6", "SIOCPROTOPRIVATE_7", "SIOCPROTOPRIVATE_8", "SIOCPROTOPRIVATE_9", "SIOCPROTOPRIVATE_A", "SIOCPROTOPRIVATE_B", "SIOCPROTOPRIVATE_C", "SIOCPROTOPRIVATE_D",
			"SIOCPROTOPRIVATE_E", "SIOCPROTOPRIVLAST", "SIOCDEVPRIVATE", "SIOCDEVPRIVATE_1", "SIOCDEVPRIVATE_2", "SIOCDEVPRIVATE_3", "SIOCDEVPRIVATE_4", "SIOCDEVPRIVATE_5", "SIOCDEVPRIVATE_6", "SIOCDEVPRIVATE_7",
			"SIOCDEVPRIVATE_8", "SIOCDEVPRIVATE_9", "SIOCDEVPRIVATE_A", "SIOCDEVPRIVATE_B", "SIOCDEVPRIVATE_C", "SIOCDEVPRIVATE_D", "SIOCDEVPRIVATE_E", "SIOCDEVPRIVLAST", "SIOCIWFIRST", "SIOCSIWCOMMIT",
			"SIOCGIWNAME", "SIOCSIWNWID", "SIOCGIWNWID", "SIOCSIWFREQ", "SIOCGIWFREQ", "SIOCSIWMODE", "SIOCGIWMODE", "SIOCSIWSENS", "SIOCGIWSENS", "SIOCSIWRANGE",
			"SIOCGIWRANGE", "SIOCSIWPRIV", "SIOCGIWPRIV", "SIOCSIWSTATS", "SIOCGIWSTATS", "SIOCSIWSPY", "SIOCGIWSPY", "SIOCSIWTHRSPY", "SIOCGIWTHRSPY", "SIOCSIWAP",
			"SIOCGIWAP", "SIOCSIWMLME", "SIOCGIWAPLIST", "SIOCSIWSCAN", "SIOCGIWSCAN", "SIOCSIWESSID", "SIOCGIWESSID", "SIOCSIWNICKN", "SIOCGIWNICKN", "SIOCSIWRATE",
			"SIOCGIWRATE", "SIOCSIWRTS", "SIOCGIWRTS", "SIOCSIWFRAG", "SIOCGIWFRAG", "SIOCSIWTXPOW", "SIOCGIWTXPOW", "SIOCSIWRETRY", "SIOCGIWRETRY", "SIOCSIWENCODE",
			"SIOCGIWENCODE", "SIOCSIWPOWER", "SIOCGIWPOWER", "SIOCSIWGENIE", "SIOCGIWGENIE", "SIOCSIWAUTH", "SIOCGIWAUTH", "SIOCSIWENCODEEXT", "SIOCGIWENCODEEXT", "SIOCSIWPMKSA",
			"SIOCIWFIRSTPRIV", "SIOCIWFIRSTPRIV_01", "SIOCIWFIRSTPRIV_02", "SIOCIWFIRSTPRIV_03", "SIOCIWFIRSTPRIV_04", "SIOCIWFIRSTPRIV_05", "SIOCIWFIRSTPRIV_06", "SIOCIWFIRSTPRIV_07", "SIOCIWFIRSTPRIV_08", "SIOCIWFIRSTPRIV_09",
			"SIOCIWFIRSTPRIV_0A", "SIOCIWFIRSTPRIV_0B", "SIOCIWFIRSTPRIV_0C", "SIOCIWFIRSTPRIV_0D", "SIOCIWFIRSTPRIV_0E", "SIOCIWFIRSTPRIV_0F", "SIOCIWFIRSTPRIV_10", "SIOCIWFIRSTPRIV_11", "SIOCIWFIRSTPRIV_12", "SIOCIWFIRSTPRIV_13",
			"SIOCIWFIRSTPRIV_14", "SIOCIWFIRSTPRIV_15", "SIOCIWFIRSTPRIV_16", "SIOCIWFIRSTPRIV_17", "SIOCIWFIRSTPRIV_18", "SIOCIWFIRSTPRIV_19", "SIOCIWFIRSTPRIV_1A", "SIOCIWFIRSTPRIV_1B", "SIOCIWFIRSTPRIV_1C", "SIOCIWFIRSTPRIV_1D",
			"SIOCIWFIRSTPRIV_1E", "SIOCIWLASTPRIV"
		};
			
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			string text4 = "";
			string text5 = "";
			int num = 0;
			int num2 = 0;
			TextReader textReader = new StringReader(textBox1.Text);
	

			for (int i = 1; i < 30; i++)
			{
				string text6 = textReader.ReadLine();
				text2 = "";
				text3 = "";
				text4 = "";
				text5 = "";
				num = 0;
				num2 = 0;
				if (text6 == null || text6.Length <= 0)
				{
					continue;
				}
				string[] array = text6.Split(' ');
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j] == "{" && array[j + 2] == "}")
					{
						text2 = array[j + 1];
					}
					if (array[j].IndexOf("scontext") == 0)
					{
						string[] array2 = array[j].Split(':');
						text3 = array2[2];
					}
					else if (array[j].IndexOf("tcontext") == 0)
					{
						string[] array2 = array[j].Split(':');
						text4 = array2[2];
					}
					else if (array[j].IndexOf("tclass") == 0)
					{
						string[] array2 = array[j].Split('=');
						text5 = array2[1];
					}
					else if (array[j].IndexOf("ioctlcmd") == 0)
					{
						string[] array2 = array[j].Split('=');
						num2 = Convert.ToInt32(array2[1], 16);
						for (num = 0; num != arrIoctrlVal.Length && arrIoctrlVal[num] != num2; num++)
						{
						}
					}
				}
				string text7 = text;
				text = text7 + "allow " + text3 + " " + text4 + ":" + text5 + " { " + text2 + " };\r\n";
				if (text2 == "ioctl")
				{
					text7 = text;
					text = text7 + "allowxperm " + text3 + " " + text4 + ":" + text5 + " " + text2 + " { " + arrIoctrlText[num] + " };\r\n";
				}
			}
			textBox2.Text = text;
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			textBox1.Text = @"audit(0.0:53): avc: denied { execute } for  path=""/data/data/com.mofing/qt-reserved-files/plugins/platforms/libgnustl_shared.so"" dev=""nandl"" ino=115502 scontext=u:r:platform_app:s0 tcontext=u:object_r:app_data_file:s0 tclass=file permissive=0";
		}
	}
}
