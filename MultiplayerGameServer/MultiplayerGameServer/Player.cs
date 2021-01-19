using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MultiplayerGameServer {
    class Player {
        public int id;
        public string username;

        public Vector3 position;
        public Quaternion rotation;

        private Vector2 movementDirection;

        private float moveSpeed = 1f / Constants.TICKS_PER_SEC;
        private bool[] inputs;

        public Player(int _id, string _username, Vector3 _spawnPosition)
        {
            id = _id;
            username = _username;
            position = _spawnPosition;
            rotation = Quaternion.Identity;
            movementDirection = Vector2.Zero;

            inputs = new bool[4];
        }

        public void Update()
        {
            if (inputs[0])
            {
                inputs[0] = false;
                RandomiseMovement();
            }

            Move(movementDirection);
        }

        private void Move(Vector2 _inputDirections)
        {
            Vector3 _moveDirection = new Vector3(_inputDirections.X, _inputDirections.Y, 0);
            position += _moveDirection * moveSpeed;

            ServerSend.PlayerPosition(this);
        }

        public void SetInput(bool[] _inputs, Quaternion _rotation)
        {
            inputs = _inputs;
            rotation = _rotation;
        }

        private void RandomiseMovement()
        {
            Random rnd = new Random();
            double angle = rnd.Next(0, 360);
            double dirX = Math.Sin(angle);
            double dirY = Math.Cos(angle);

            movementDirection = new Vector2((float)dirX, (float)dirY);
        }
    }
}
