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

namespace ComicTime.data.Source
{
    class CharacterRepository : CharacterDataSource
    {
        public void getCharacters(Func<List<Character>> getCharactersCallBack)
        {
            throw new NotImplementedException();
        }

        public void refreshCharacters()
        {
            throw new NotImplementedException();
        }
    }
}