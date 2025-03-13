namespace Kevsoft.WLED;

using System.Collections.Generic;

public class Segment
{
    public int Id { get; set; }
    public int Start { get; set; }
    public int Stop { get; set; }
    public int Grp { get; set; }
    public int Spc { get; set; }
    public int Of { get; set; }
    public bool On { get; set; }
    public bool Frz { get; set; }
    public int Bri { get; set; }
    public int Cct { get; set; }
    public int Set { get; set; }
    public string? N { get; set; }
    public List<List<int>>? Col { get; set; }
    public int Fx { get; set; }
    public int Sx { get; set; }
    public int Ix { get; set; }
    public int Pal { get; set; }
    public int C1 { get; set; }
    public int C2 { get; set; }
    public int C3 { get; set; }
    public bool Sel { get; set; }
    public bool Rev { get; set; }
    public bool Mi { get; set; }
    public bool O1 { get; set; }
    public bool O2 { get; set; }
    public bool O3 { get; set; }
    public int Si { get; set; }
    public int M12 { get; set; }
}

public class WledPreset
{
    public bool On { get; set; }
    public int Bri { get; set; }
    public int Transition { get; set; }
    public int Mainseg { get; set; }
    public List<Segment>? Seg { get; set; }
    public string? N { get; set; }
    public int Id { get; set; }

    public override string ToString()
    {
        return $"({Id}) {N}: On={On}, Bri={Bri}, SegCount={Seg?.Count}";
    }
}




