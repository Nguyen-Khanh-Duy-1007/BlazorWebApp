namespace BlazorMovieApp.Components.Pages
{
    public partial class Study
    {
        private string selectedValue { get; set; } = "Alabama";
        private IEnumerable<Movie> movies = new List<Movie>();
        private MudTable<Movie>? _movieTb;
        MovieDbContext context = default!;
        bool _dense;
        bool _disabled;
        bool _readonly;
        bool _placeholder;
        bool _helperText;
        bool _helperTextOnFocus;
        bool _clearable;
        private string TextValue { get; set; } = string.Empty;

        private string[] _states =
        {
        "Alabama", "Alaska", "Arizona", "Arkansas", "California",
        "Colorado", "Connecticut", "Delaware", "Florida", "Georgia",
        "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas",
        "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts",
        "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana",
        "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico",
        "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma",
        "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota",
        "Tennessee", "Texas", "Utah", "Vermont", "Virginia",
        "Washington", "West Virginia", "Wisconsin", "Wyoming"
        };

        protected override void OnInitialized()
        {
            context = DbFactory.CreateDbContext();
            movies = context.Movie.ToList();
        }
    }
}
