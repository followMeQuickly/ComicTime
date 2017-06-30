
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Bumptech.Glide;
using ComicTime.data;
using Java.Lang;
using Square.Picasso;

namespace ComicTime.Characters
{
    public class CharactersFragment : Fragment, CharactersContract.IView<CharactersContract.Presenter>
    {

        private CharactersContract.Presenter presenter;
        private CharacterAdapter characterAdapter;
        private ImageView view;
        private TextView textView;
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
            var thing = root.Id;
            textView = root.FindViewById<TextView>(Resource.Id.names);            //var grid = root.FindViewById<GridView>(Resource.Id.gridview);
            //characterAdapter = new CharacterAdapter(root.Context, new List<Character>());
            //if (characterAdapter != null)
            //{
                
            //}
            //grid.Adapter = characterAdapter;
           


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
            string names = "";
            characters.ForEach(item =>
            {
                names = item.name + " \n";
            });
            textView.SetText(names.ToCharArray(), 0, names.Length);

            //var url = characters[0].resourceURI;
            //characterAdapter.UpdateList(characters);
               
        }

        public void showNoCharacters()
        {
            throw new NotImplementedException();
        }
    }


    public class CharacterAdapter: BaseAdapter
    {
        private List<Character> characters;
        private Context context;

        public CharacterAdapter(Context context, List<Character> characters)
        {
            this.context = context;
            this.characters = characters;
        }

        public override int Count => characters.Count;

        public override void NotifyDataSetChanged()
        {
            base.NotifyDataSetChanged();
        }
        public override void RegisterDataSetObserver(Android.Database.DataSetObserver observer)
        {
            base.RegisterDataSetObserver(observer);
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            throw new NotImplementedException();
        }
        public override long GetItemId(int position)
        {
            return characters.ElementAt(position).id;
        }
        public void UpdateList(List<Character> characters)
        {
            this.characters = characters;
            NotifyDataSetChanged();
        }

       

        public override Java.Lang.Object GetItem(int position)
        {
            return (Java.Lang.Object) characters.ElementAt(position);
        }
    }
}
