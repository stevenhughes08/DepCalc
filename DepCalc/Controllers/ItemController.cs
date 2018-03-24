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
            using (var depCalcContext = new DepCalcContext())
            {
                var itemList = new ItemListViewModel
                {
                    //Convert each InvItem to a ItemViewModel
                    Items = depCalcContext.Items.Select(p => new ItemViewModel
                    {
                        //Items are sorted by how they should appear for Steve's sanity.
                        ItemId = p.ItemId,
                        ItemName = p.ItemName,
                        GenLedger = p.GenLedger,
                        QtyServUnit = p.QtyServUnit,
                        QtyCount = p.QtyCount,
                        CountUnit = p.CountUnit,
                        PurchUnit = p.PurchUnit,
                        SellUnit = p.SellUnit,
                        CountFrequency = p.CountFrequency,
                        StandCost = p.StandCost
                       

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
                        QtyCount = item.QtyCount,
                        CountUnit = item.CountUnit,
                        PurchUnit = item.PurchUnit,
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

            using (var depCalcContext = new DepCalcContext())
            {
                var item = new Item
                {
                    //ItemId = nextItemId,
                    ItemName = itemViewModel.ItemName,
                    GenLedger = itemViewModel.GenLedger,
                    QtyServUnit = itemViewModel.QtyServUnit,
                    QtyCount = itemViewModel.QtyCount,
                    CountUnit = itemViewModel.CountUnit,
                    PurchUnit = itemViewModel.PurchUnit,
                    SellUnit = itemViewModel.SellUnit,
                    CountFrequency = itemViewModel.CountFrequency,
                    StandCost = itemViewModel.StandCost
                    
                };

                depCalcContext.Items.Add(item);
                depCalcContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }



        public ActionResult ItemEdit(int id)
        {
            //When refractoring this is close to the code in the itemDetail action
            //This handles the AddEditItem function. 
            using (var depCalcContext = new DepCalcContext())
            {
                var item = depCalcContext.Items.SingleOrDefault(p => p.ItemId == id);
                if (item != null)
                {
                    var itemViewModel = new ItemViewModel
                    {
                        ItemId = item.ItemId,
                        ItemName = item.ItemName,
                        GenLedger = item.GenLedger,
                        QtyServUnit = item.QtyServUnit,
                        QtyCount = item.QtyCount,
                        CountUnit = item.CountUnit,
                        PurchUnit = item.PurchUnit,
                        SellUnit = item.SellUnit,
                        CountFrequency = item.CountFrequency,
                        StandCost = item.StandCost
                       
                    };
                    return View("AddEditItem", itemViewModel);
                }
               
            }

            return new HttpNotFoundResult();
        }
       
        
        [HttpPost]
        public ActionResult EditItem(ItemViewModel itemViewModel)
        {

            using (var depCalcContext = new DepCalcContext())
            {

                var item = depCalcContext.Items.SingleOrDefault(p => p.ItemId == itemViewModel.ItemId);
                if (item != null)
                {
                    
                    item.ItemName = itemViewModel.ItemName;
                    item.GenLedger = itemViewModel.GenLedger;
                    item.QtyServUnit = itemViewModel.QtyServUnit;
                    item.QtyCount = itemViewModel.QtyCount;
                    item.CountUnit = itemViewModel.CountUnit;
                    item.PurchUnit = itemViewModel.PurchUnit;
                    item.SellUnit = itemViewModel.SellUnit;
                    item.CountFrequency = itemViewModel.CountFrequency;
                    item.StandCost = itemViewModel.StandCost;

                    depCalcContext.SaveChanges();


                    return RedirectToAction("Index");
                }
                
            }

            return new HttpNotFoundResult();

        }
                


        [HttpPost]
        public ActionResult DeleteItem(ItemViewModel itemViewModel)
        {
            using (var depCalcContext = new DepCalcContext())
            {
                var item = depCalcContext.Items.SingleOrDefault(p => p.ItemId == itemViewModel.ItemId);
                    if(item != null)
                    {
                    depCalcContext.Items.Remove(item);
                    depCalcContext.SaveChanges();
                    return RedirectToAction("Index");
                    }

              
            }

            return new HttpNotFoundResult();
        }





    }


}