using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WFAHamburgerci
{
	class FileHelper
	{
		private static string MainDirectoryPath = @"C:\odev2"; // global,static değistirilmesin diye// global değ. bütük harfle basşar
		private static string MenuPath = Path.Combine(MainDirectoryPath, "Menuler.xml");// adresi birlestirmek için
		public static void KlasorYarat()
		{
			if (!Directory.Exists(MainDirectoryPath))
				Directory.CreateDirectory(MainDirectoryPath); //ctrl+.
		}
		
		public static void MenuDosyaYarat()
		{
			if (!File.Exists(MenuPath))
			{
				var file = File.Create(MenuPath);
				file.Close();
			}
		}

		public static void MenuIlkDegerleriniDoldur()
		{
			List<Menu> menuler = new List<Menu>()
			 {
				 new Menu{MenuAdi= "Steakhouse", Fiyati=18.25m},
				 new Menu{MenuAdi= "Mcfish", Fiyati=8}
			 };

			MenuSchema menuSchema = new MenuSchema();

			List<MenuSchemaMenu> menuItemList = new List<MenuSchemaMenu>
			{
				new MenuSchemaMenu() {MenuAdi="Steakhouse", Fiyati=15}
			};

			menuSchema.Menu = menuItemList.ToArray();

			XmlSerializer xs = new XmlSerializer(typeof(MenuSchema));
			string xml = "";

			using (StringWriter sw = new StringWriter())
			{
				using (XmlWriter writer = XmlWriter.Create(sw))
				{
					xs.Serialize(writer, menuSchema);
					xml = sw.ToString();
				}
			}
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(xml);
			xmlDoc.Save(MenuPath);
		}

		public static List<Menu> MenuleriOku()
		{
			List<Menu> menuList = new List<Menu>();

			if (File.Exists(MenuPath))
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load(MenuPath);

				XmlNode menuNode = xmlDoc.ChildNodes[1];
				

				foreach (XmlNode item in menuNode)
				{
					menuList.Add(new Menu() { MenuAdi = item["MenuAdi"].InnerText.Trim(), Fiyati = Convert.ToDecimal(item["Fiyati"].InnerText.Trim()) });
				}
				
			}
			return menuList;
		}
	}
}
