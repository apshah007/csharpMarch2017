using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//namespace MyGiftCloset.Entities

//namespace CLproject
//{
//   this is not a working respository 
//
//    public class GroceryRepository
//    {
//            public IEnumerable<Product> GetAllItems()
//            {
//                return _database.Product
//                    .Include(g => g.ProductName)
//                    .Include(g => g.InCart)
//                    .ToList();
//            }
//            public Gift GetGift(int Id)
//            {
//                return _database.Gifts
//                    .Where(g => g.Id == Id)
//                    .Include(g => g.ProductName)
//                    .Include(g => g.InCart)
//                    .FirstOrDefault();
//            }
//            public void AddGift(Gift gift)
//            {
//                _database.Gifts.Add(gift);
//                _database.SaveChanges();
//            }
//            public void DeleteGift(int Id)
//            {
//                var gift = GetGift(Id);
//                if (gift != null)
//                {
//                    _database.Gifts.Remove(gift);
//                    _database.SaveChanges();
//                }
//            }
//            public void UpdateGift(Gift gift)
//            {
//                var dbGift = GetGift(gift.Id);
//                if (dbGift != null)
//                {
//                    dbGift = gift;
//                    _database.SaveChanges();
//                }
//            }
//            public void UpdateAllGifts(IEnumerable<Gift> gifts)
//            {

//            }
//        }
//    }

//}
//}

