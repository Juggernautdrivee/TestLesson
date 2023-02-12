using System;
class Emploe
{
    public int Rank { get; }
    public bool IsLeader { get; }
    public Emploe(int rank, bool IsLeader)
    {
        this.Rank = rank;
        this.IsLeader = IsLeader;
    }

}
