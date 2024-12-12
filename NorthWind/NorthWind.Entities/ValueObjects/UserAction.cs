﻿namespace NorthWind.Entities.ValueObjects;

public class UserAction(string user, string dercription)
{
    public DateTime CreateDateTime { get; } = DateTime.Now;
    public string User => user;
    public string Dercription => dercription;

}