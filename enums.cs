var today = (Season)99;
Console.WriteLine(DescribeSeason(today));

static string DescribeSeason(Season season) => season switch
{
  Season.Spring => "Flowers bloom and temperatures rise.",
  Season.Summer => "Long days and warm weather.",
  Season.Autumn => "Leaves change color and fall.",
  Season.Winter => "Short days and cold temperatures.",
  _ => "Did not match"
};

enum Season
{
  Spring,
  Summer,
  Autumn,
  Winter
}
