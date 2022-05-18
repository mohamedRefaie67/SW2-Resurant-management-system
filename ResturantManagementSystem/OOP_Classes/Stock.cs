using ResturantManagementSystem.OOP_Classes.DataBaseHandel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantManagementSystem.OOP_Classes
{
    class Stock
    {
        private int goodId;
        private String goodName;
        private float costPerOne;
        private float quantity;

        public Stock()
        {
        }

        public Stock(int goodId, string goodName, float costPerOne, float quantity)
        {
            this.GoodId = goodId;
            this.GoodName = goodName;
            this.CostPerOne = costPerOne;
            this.Quantity = quantity;
        }

        public int GoodId { get => goodId; set => goodId = value; }
        public string GoodName { get => goodName; set => goodName = value; }
        public float CostPerOne { get => costPerOne; set => costPerOne = value; }
        public float Quantity { get => quantity; set => quantity = value; }

        /********************************************************************/
        public void save()
        {
            new StockRepository().save(this);
        }
        public void update()
        {
            new StockRepository().update(this);
        }
        public void delete()
        {
            new StockRepository().delete(this);
        }
    }
}
