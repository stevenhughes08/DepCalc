using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DepCalc.Models;


namespace DepCalc.Controllers
{
    public class ItemController : Controller
    {
        

        public ActionResult Index()
        {
            using (var DepCalcContext = new DepCalcContext())
            {
                var itemList = new ItemListViewModel
                {
                    //Convert each InvItem to a ItemViewModel
                    Items = DepCalcContext.Items.Select(p => new ItemViewModel
                    {
                        //Items are sorted by how they should appear for Steve's sanity.
                        ItemId = p.ItemId,
                        ItemName = p.ItemName,

                        QtyServUnit = p.QtyServUnit,
                        CountUnit = p.CountUnit,

                        //QtyCountUnit = p.QtyCountUnit,
                        SellUnit = p.SellUnit,

                        CountFrequency = p.CountFrequency,
                        StandCost = p.StandCost,
                        GenLedger = p.GenLedger

                    }).ToList()
                };

                itemList.TotalItems = itemList.Items.Count;
                return View(itemList);
            }

        }


        public ActionResult ItemDetail(int id)
        {

            using (var DepCalcContext = new DepCalcContext())
            {

                var item = DepCalcContext.Items.SingleOrDefault(p => p.ItemId == id);
                if (item != null)
                {

                    var itemViewModel = new ItemViewModel
                    {

                        ItemId = item.ItemId,
                        ItemName = item.ItemName,
                        GenLedger = item.GenLedger,
                        QtyServUnit = item.QtyServUnit,
                        CountUnit = item.CountUnit,
                        SellUnit = item.SellUnit,
                        CountFrequency = item.CountFrequency,
                        StandCost = item.StandCost,
                       

                    };

                    return View(itemViewModel);
                }

            }

            return new HttpNotFoundResult();

        }


                public ActionResult ItemAdd()
                {

                    var itemViewModel = new ItemViewModel();
                    return View("AddEditItem", itemViewModel);

                }

        [HttpPost]
        public ActionResult AddItem(ItemViewModel itemViewModel)
        {

            using (var DepCalcContext = new DepCalcContext())
            {
                var item = new Item
                {
                    //ItemId = nextItemId,
                    ItemName = itemViewModel.ItemName,
                    GenLedger = itemViewModel.GenLedger,
                    QtyServUnit = itemViewModel.QtyServUnit,
                    CountUnit = itemViewModel.CountUnit,
                    SellUnit = itemViewModel.SellUnit,
                    CountFrequency = itemViewModel.CountFrequency,
                    StandCost = itemViewModel.StandCost,
                    
                };
                DepCalcContext.Items.Add(item);
                DepCalcContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }



        public ActionResult ItemEdit(int id)
        {
            //When refractoring this is close to the code in the itemDetail action
            //This handles the AddEditItem function. 
            using (var DepCalcContext = new DepCalcContext())
            {
                var item = DepCalcContext.Items.SingleOrDefault(p => p.ItemId == id);
                if (item != null)
                {
                    var itemViewModel = new ItemViewModel
                    {
                        ItemId = item.ItemId,
                        ItemName = item.ItemName,
                        GenLedger = item.GenLedger,
                        QtyServUnit = item.QtyServUnit,
                        CountUnit = item.CountUnit,
                        SellUnit = item.SellUnit,
                        CountFrequency = item.CountFrequency,
                        StandCost = item.StandCost
                       
                    };
                    return View("AddEditItem", itemViewModel);
                }
                return new HttpNotFoundResult();
            }
        }
        //Handles retreving the new item. 
        [HttpPost]
        public ActionResult EditItem(ItemViewModel itemViewModel)
        {

            using (var DepCalcContext = new DepCalcContext())
            { var item = DepCalcContext.Items.SingleOrDefault(p => p.ItemId == itemViewModel.ItemId);
                if (item != null)
                {
                    item.ItemName = ItemViewModel.ItemName;
                    item.GenLedger = ItemViewModel.GenLedger;
                    item.QtyServUnit = ItemViewModel.QtyServUnit;
                    item.CountUnit = ItemViewModel.CountUnit;
                    item.SellUnit = ItemViewModel.SellUnit;
                    item.CountFrequency = ItemViewModel.CountFrequency;
                    item.StandCost = ItemViewModel.StandCost;

                    return RedirectToAction("Index");
                }

                return new HttpNotFoundResult();
            }

            
        }
                


        [HttpPost]
        public ActionResult DeleteItem(ItemViewModel itemViewModel)
        {
            using (var DepCalcContext = new DepCalcContext())
            {
                var item = DepCalcContext.Items.SingleOrDefault(p => p.ItemId == itemViewModel.ItemId);
                    if(item != null)
                    {
                    DepCalcContext.Items.Remove(item);
                    DepCalcContext.SaveChanges();
                    return RedirectToAction("Index");
                    }

              
            }

            return new HttpNotFoundResult();
        }





    }


}