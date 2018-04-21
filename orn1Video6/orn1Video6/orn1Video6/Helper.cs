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
using Newtonsoft.Json;

namespace orn1Video6
{
    public static class Helper
    {

        static public string toJson_benim_Yaptigim(this object item)/*bu sekilde yaparak string degere . koydugunda bu fonk calısır*/
        {
            var value = JsonConvert.SerializeObject(item);
            return value;


        }

        static public T From_Benim_Yaptigim_Json<T>(string item)
        {
            return JsonConvert.DeserializeObject<T>(item);

        }

    }
}