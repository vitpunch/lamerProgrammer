using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace lamerProgrammer.Models
{
    public class Story
    {
        public string Title { get; private set; }
        public string StoryContent { get; private set; }
        public Story()
        {
        }
        public void Index()
        {

        }
        public void Random()
        {
            

            Random Rnd = new Random();
            int num = Rnd.Next(5);


            DataTable Table = MySQL.Select("SELECT `title`, `story` FROM `story`");
            Title = Table.Rows[num]["title"].ToString();
            StoryContent = Table.Rows[num]["story"].ToString();

        }
        public void Add()
        {

        }
        public void Hot()
        {

        }
        public void About()
        {

        }
        public void Number()
        {

        }

    }
}