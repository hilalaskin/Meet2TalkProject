using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Rover
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public char Direction { get; private set; }

    public Rover(int x, int y, char direction)
    {
        X = x;
        Y = y;
        Direction = direction;
    }

    public void TurnLeft()
    {
        switch (Direction)
        {
            case 'N':
                Direction = 'W';
                break;
            case 'W':
                Direction = 'S';
                break;
            case 'S':
                Direction = 'E';
                break;
            case 'E':
                Direction = 'N';
                break;
        }
    }

    public void TurnRight()
    {
        switch (Direction)
        {
            case 'N':
                Direction = 'E';
                break;
            case 'E':
                Direction = 'S';
                break;
            case 'S':
                Direction = 'W';
                break;
            case 'W':
                Direction = 'N';
                break;
        }
    }

    public void Move()
    {
        switch (Direction)
        {
            case 'N':
                Y++;
                break;
            case 'E':
                X++;
                break;
            case 'S':
                Y--;
                break;
            case 'W':
                X--;
                break;
        }
    }

    public void ExecuteInstructions(string instructions)
    {
        foreach (char instruction in instructions)
        {
            switch (instruction)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'M':
                    Move();
                    break;
            }
        }
    }

    public override string ToString()
    {
        return $"{X} {Y} {Direction}";
    }
}

