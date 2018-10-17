using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App3
{
    class ListItem
    {

       public int Id { get; set; }
       public string Title { get; set; }
       public string Subtitle { get; set; }
       public string Distance { get; set; }
       public string Image { get; set; }


    }
}