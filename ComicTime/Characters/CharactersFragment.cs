
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

        private CharactersContract.Presenter presenter;

        public bool isActive()
        {
            throw new NotImplementedException();
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override void OnResume()
        {
            base.OnResume();
            presenter.start();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            var root = inflater.Inflate(Resource.Layout.CharactersFragment, container, false);
            var text = root.FindViewById(Resource.Id.textView);


            return root;
        }

        public void setLoadIndicator(bool active)
        {
            throw new NotImplementedException();
        }

        public void setPresenter(CharactersContract.Presenter presenter)
        {
            this.presenter = presenter;
        }

        public void showCharacters(List<Character> characters)
        {
            throw new NotImplementedException();
        }

        public void showNoCharacters()
        {
            throw new NotImplementedException();
        }
    }
}
