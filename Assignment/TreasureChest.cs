﻿using System;

namespace Assignment
{
    public class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        public TreasureChest()
        {
            _material = Material.Iron;
            _lockType = LockType.Expert;
            _lootQuality = LootQuality.Green;
        }

        public TreasureChest(State state) : this()
        {
            _state = state;
        }

        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }

        public State GetState()
        {
            return _state;
        }

        public State Manipulate(Action action)
        {
            if (action == Action.Open)
            {
                Open();
            }
            else if (action == Action.Close)
            {
                Close();
            }
            else if (action == Action.Lock)
            {
                Lock();
            }
            else if (action == Action.Unlock)
            {
                Unlock();
            }
            return _state;
        }

        public void Unlock()
        {
            if (_state == State.Locked)
            {
                _state = State.Unlocked;
            }
            else if (_state == State.Unlocked)
            {
                Console.WriteLine("The chest is already unlocked!");
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest cannot be unlocked because it is already open.");
            }
            else if (_state == State.Closed)
            {
                Console.WriteLine("The chest cannot be unlocked because it is already closed.");
            }
        }

        public void Lock()
        {
            if (_state == State.Closed)
            {
                _state = State.Locked;
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest is already locked!");
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest cannot be locked because it is open.");
            }
            else if (_state == State.Unlocked)
            {
                Console.WriteLine("The chest cannot be locked because it is unlocked.");
            }
        }

        public void Open()
        {
            if (_state == State.Closed)
            {
                _state = State.Open;
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest is already open!");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be opened because it is locked.");
            }
            else if (_state == State.Unlocked)
            {
                Console.WriteLine("The chest cannot be opened because it is unlocked.");
            }
        }

        public void Close()
        {
            if (_state == State.Open)
            {
                _state = State.Closed;
            }
            else if (_state == State.Closed)
            {
                Console.WriteLine("The chest is already closed!");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be closed because it is locked.");
            }
            else if (_state == State.Unlocked)
            {
                Console.WriteLine("The chest cannot be closed because it is unlocked.");
            }
        }

        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        private static void ConsoleHelper(string prop1, string prop2, string prop3)
        {
            Console.WriteLine($"Choose from the following properties.\n1.{prop1}\n2.{prop2}\n3.{prop3}");
        }

        public enum State { Open, Closed, Locked, Unlocked };
        public enum Action { Open, Close, Lock, Unlock };
        public enum Material { Oak, RichMahogany, Iron };
        public enum LockType { Novice, Intermediate, Expert };
        public enum LootQuality { Grey, Green, Purple };
    }
}