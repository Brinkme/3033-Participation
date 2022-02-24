using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorris
{
    public class Chuck
    {
        public List<Category> categories { get; set; }

        public string created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }

    }

    public class Category
    {
   public string animal         {get; set;}
   public string career         {get; set;}
   public string celebrity      {get; set;}
   public string dev            {get; set;}
   public string fashion        {get; set;}
   public string food           {get; set;}
   public string history        {get; set;}
   public string money          {get; set;}
   public string movie          {get; set;}
   public string music          {get; set;}
   public string political      {get; set;}
   public string religion       {get; set;}
   public string science        {get; set;}
   public string sport          {get; set;}
   public string travel         { get; set; }

   //public string explicit       {get; set;}






    }
}
