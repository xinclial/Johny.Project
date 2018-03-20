using Johny.Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Johny.Project.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult LeftMenu()
        {
            List<Menu> menuList = new List<Menu>();

            string[] Menus = { "客户管理", "销售管理", "钢瓶管理", "客服管理", "系统管理", "综合查询", "财务管理", "统计报表" };

            string[] childnode1 = { "预开户", "正式客户", "客户卡", "设备信息", "历史状态" };

            string[] childnode2 = { "订单下单", "订单门售", "车辆/人员调拨", "订单配送", "订单销售" };

            string[] childnode3 = { "库存管理", "钢瓶出入库", "钢瓶追溯", "扫描考核", "环节抽查", "外区统计" };

            string[] childnode4 = { "投诉保修", "安全巡检", "巡检整改", "业务回访" };

            string[] childnode5 = { "员工管理", "部门管理" };

            string[] childnode6 = { "综合统计", "客户业务查询", "客户分类查询", "销售分类查询", "客户信息查询", "客户账务查询" };

            string[] childnode7 = { "结账", "解款", "凭证录入", "报数", "支票管理", "预存款管理", "手工回执录入", "银行文件查询", "报数确认", "对账", "赊销查询", "待处理管理", "华期" };

            string[] childnode8 = { "业务报表", "财务报表" };

            for (int i = 0; i < Menus.Length; i++)
            {
                Menu m = new Menu();
                m.ID = i + 1;
                m.Href = string.Empty;
                m.Name = Menus[i].ToString();
                menuList.Add(m);
            }

            for (int i = 0; i < childnode1.Length; i++)
            {
                ChildNode child = new ChildNode();
                child.ID = i + 1;
                child.ChildHref = string.Empty;
                child.ChildName = childnode1[i].ToString();
                menuList[0].Nodes.Add(child);
            }

            for (int i = 0; i < childnode2.Length; i++)
            {
                ChildNode child = new ChildNode();
                child.ID = i + 1;
                child.ChildHref = string.Empty;
                child.ChildName = childnode2[i].ToString();
                menuList[1].Nodes.Add(child);
            }

            for (int i = 0; i < childnode3.Length; i++)
            {
                ChildNode child = new ChildNode();
                child.ID = i + 1;
                child.ChildHref = string.Empty;
                child.ChildName = childnode3[i].ToString();
                menuList[2].Nodes.Add(child);
            }

            for (int i = 0; i < childnode4.Length; i++)
            {
                ChildNode child = new ChildNode();
                child.ID = i + 1;
                child.ChildHref = string.Empty;
                child.ChildName = childnode4[i].ToString();
                menuList[3].Nodes.Add(child);
            }

            for (int i = 0; i < childnode5.Length; i++)
            {
                ChildNode child = new ChildNode();
                child.ID = i + 1;
                child.ChildHref = string.Empty;
                child.ChildName = childnode5[i].ToString();
                menuList[4].Nodes.Add(child);
            }

            for (int i = 0; i < childnode6.Length; i++)
            {
                ChildNode child = new ChildNode();
                child.ID = i + 1;
                child.ChildHref = string.Empty;
                child.ChildName = childnode6[i].ToString();
                menuList[5].Nodes.Add(child);
            }

            for (int i = 0; i < childnode7.Length; i++)
            {
                ChildNode child = new ChildNode();
                child.ID = i + 1;
                child.ChildHref = string.Empty;
                child.ChildName = childnode7[i].ToString();
                menuList[6].Nodes.Add(child);
            }

            for (int i = 0; i < childnode8.Length; i++)
            {
                ChildNode child = new ChildNode();
                child.ID = i + 1;
                child.ChildHref = string.Empty;
                child.ChildName = childnode8[i].ToString();
                menuList[7].Nodes.Add(child);
            }

            return PartialView(menuList);

        }
    }
}