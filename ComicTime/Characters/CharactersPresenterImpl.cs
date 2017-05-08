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
    public class CharactersPresenterImpl : CharactersContract.Presenter    {

        private data.Source.CharacterDataSource repository;
        private CharactersContract.IView<CharactersContract.Presenter> view;

        public CharactersPresenterImpl(data.Source.CharacterDataSource repository, 
                                       CharactersContract.IView<Characters.CharactersContract.Presenter> view)
        {
            this.repository = repository;
            this.view = view;

            view.setPresenter(this);

        }
        public void result(int requestCode, int resultCode)
        {

        }

        public void start()
        {
            loadCharacters(false);
            loadCharacters(true);
        }

        public void openCharacterDetails(Character requestedCharacter)
        {

        }

        public void clearCharacterList()
        {

        }

        public void setFiltering()
        {

        }

        public void loadCharacters(bool forceUpdate)
        {
            Console.WriteLine("getting da characters");
            //repository.refreshCharacters();

        }
    }
}