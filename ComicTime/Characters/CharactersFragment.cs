using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using ComicTime.data;

namespace ComicTime.Characters
{
    public class CharactersFragment : Fragment, CharactersContract.IView<CharactersContract.Presenter>
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return base.OnCreateView(inflater, container, savedInstanceState);
        }

        

        void CharactersContract.IView<CharactersContract.Presenter>.setLoadIndicator(bool active)
        {
            throw new NotImplementedException();
        }

        void CharactersContract.IView<CharactersContract.Presenter>.showNoCharacters()
        {
            throw new NotImplementedException();
        }

        void CharactersContract.IView<CharactersContract.Presenter>.showCharacters(List<Character> characters)
        {
            throw new NotImplementedException();
        }

        bool CharactersContract.IView<CharactersContract.Presenter>.isActive()
        {
            throw new NotImplementedException();
        }

        public void setPresenter(CharactersContract.Presenter presenter)
        {
            throw new NotImplementedException();
        }
    }
}