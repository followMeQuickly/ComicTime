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
            //loadCharacters(false);
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

        void loadCharacters(bool forceUpdate)
        {
            Console.WriteLine("getting da characters");
            List<Character> characters = new List<Character>();
            repository.getCharacters(characterss => characters = characterss);
            ProcessCharacters(characters);
           

        }
        private void ProcessCharacters(List<Character> characters)
        {

            List<Character> characterList = new List<Character>();
            characters.ForEach(character => {
                characterList.Add(character);
            });

            view.showCharacters(characterList);
            
        }

        void CharactersContract.Presenter.loadCharacters(bool forceUpdate)
        {
			//repository.getCharacters((characters) =>
			//{
   //             ProcessCharacters(characters);
			//});

		}

       

    }

}