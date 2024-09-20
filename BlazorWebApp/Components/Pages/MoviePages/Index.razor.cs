namespace BlazorWebApp.Components.Pages.MoviePages
{
    public partial class Index
    {
        private bool _selectOnRowClick;
        private bool _selectionChangeable;
        private bool _loading;
        private int _selectedRowNumber = -1;
        private IEnumerable<Movie> movies = new List<Movie>();
        private MudTable<Movie>? _movieTb;
        private string searchString = "";
        MovieDbContext context = default!;

        protected override void OnInitialized()
        {
            context = DbFactory.CreateDbContext();
            movies = context.Movie.ToList();
        }

        public async ValueTask DisposeAsync() => await context.DisposeAsync();

        private string SelectedRowClassFunc(Movie movie, int rowNumber)
        {
            if (_selectedRowNumber == rowNumber)
            {
                _selectedRowNumber = -1;
                return string.Empty;
            }
            else if(_movieTb.SelectedItem != null && _movieTb.SelectedItem.Equals(movie))
            {
                _selectedRowNumber = rowNumber;
                return "selected";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
