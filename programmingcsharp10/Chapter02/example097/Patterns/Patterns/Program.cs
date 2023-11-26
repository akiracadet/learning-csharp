return shape switch
{
    (int w, int h) when w < h => "Portrait",
    (int w, int h) when w > h => "Landscape",
    (int _, int _) => "Square",
    _ => "Unknown"
};
