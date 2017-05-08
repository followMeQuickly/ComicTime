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
using ComicTime.data;

namespace ComicTime.Characters
{
    public class CharactersContract
    {
        public interface IView<T> : BaseView<T>
        {
            void setLoadIndicator(Boolean active);

            void showNoCharacters();

            void showCharacters(List<Character> characters);

            Boolean isActive();

            

            

        }

      

        public interface Presenter : BasePresenter
        {
            void result(int requestCode, int resultCode);

            void openCharacterDetails(Character requestedCharacter);

            void clearCharacterList();

            void setFiltering();

            void loadCharacters(Boolean forceUpdate);

        }
    }
}