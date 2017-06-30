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
    public interface CharacterDataSource
    {
        void getCharacters(Action<List<Character>> characters);

        void refreshCharacters();

    }

    public interface OnCharactersLoadedCallback
    {
        void onCharacterLoaded(List<Character> characters);
        void onDataNotAvailable();
    }
    
    
}