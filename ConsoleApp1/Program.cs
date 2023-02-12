using System;
class Emploe
{
    public int rank { get; }
    public bool isLeader { get; }
    public Emploe(int rank, bool IsLeader)
    {
        this.rank = rank;
        isLeader = IsLeader;
    }

}
