using System;


namespace ConsoleApplication
{
    public class Player
    {
        int xPosition;
        int yPosition;
        int speed;
        char sprite;

        public int XPosition
        {
            get 
            {
                return xPosition;
            }

            set 
            {
                xPosition = value;
            }

        }
        
        public int YPosition
        {
            get 
            {
                return yPosition;
            }

            set 
            {
                yPosition = value;
            }

        }

        public Player()
        {
            sprite = '&';
            xPosition = 3;
            yPosition = 3;
            speed = 1;
        }

        public Player(char playerSprite)
        {
            sprite = playerSprite;
            xPosition = 3;
            yPosition = 3;
            speed = 1;
        }

        public void Draw()
        {
            Console.CursorLeft = xPosition;
            Console.CursorTop = yPosition;
            Console.Write(sprite);
        }

        public void Move(String direction)
        {
            switch(direction)
            {
                case "up":
                    yPosition -= speed;
                break;

                case "down":
                    yPosition += speed;
                break;

                case "left":
                    xPosition -= speed;
                break;

                case "right":
                    xPosition += speed;
                break;

                default:
                break;
            }

        }

    }

}