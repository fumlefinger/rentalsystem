using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class Book
    {
        string title;
        string author;
        int releaseYear;
        int rentTime;
        int costOfLoss;


        public Book(string title, string author, int releaseYear, int rentTime, int costOfLoss)
        {
            this.title = title;
            this.author = author;
            this.releaseYear = releaseYear;
            this.rentTime = rentTime;
            this.costOfLoss = costOfLoss;
        }

        public int getRentableTime()
        {
            return this.rentTime;
        }

        public void setRentableTime(int time)
        {
            this.rentTime = time;
        }

        public int getCostOfLoss()
        {
            return this.costOfLoss;
        }

        public void setCostOfLoss(int cost)
        {
            this.costOfLoss = cost;
        }

        public string getTitle()
        {
            return this.title;
        }

    }
}
