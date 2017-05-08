using Android.App;
using Android.Widget;
using Android.OS;

namespace ComicTime
{
    [Activity(Label = "ComicTime", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Characters.CharactersContract.Presenter presenter;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var repo = new data.Source.remote.CharacterRemoteRepo();
            var view = new Characters.CharactersFragment();
            presenter = new Characters.CharactersPresenterImpl(repo, view);
            FragmentTransaction fm = this.FragmentManager.BeginTransaction();

            fm.Add(view, "charactersFragment");
            fm.Commit();

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

