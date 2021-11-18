using Galactic.Models.BattleSystem;
using Galactic.VIew;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galactic.Models.Map
{
    public class GenerateMap
    {

        private delegate void SeedHandler();
        private Random _rand = new Random();
        private Button[,] _arrayButtons = new Button[_mapSize, _mapSize];
        private Button _heroButton = new Button();
        private Image _spriteSetHero;
        private Button _planetButton = new Button();
        private int _startX;
        private int _startY;
        private int _planetX;
        private int _planetY;

        private const int _mapSize = 40;
        private const int _cellSize = 20;
        public int[,] map = new int[_mapSize, _mapSize];
        private int _endPointX;
        private int _endPointY;
        public void Init(Form currentForm)
        {
            _spriteSetHero = Properties.Resources.PlayerShip;
            ConfigureMapSize(currentForm);
            InitDefaultMap();
            SeedHandler generationObject = SeedPlayer;
            generationObject += SeedPlanet;
            generationObject += SeedStation;
            generationObject();
            InitMap(currentForm);
        }

        private void SeedStation()
        {
            map[20, 20] = (int)TypePoint.Station;
        }

        private void SeedPlanet()
        {
            for (int i = 0; i < 2; i++)
            {
                int pos1 = _rand.Next(0, 39);
                int pos2 = _rand.Next(0, 39);
                while (map[pos1, pos2] == (int)TypePoint.Planet)
                {
                    pos1 = _rand.Next(0, 39);
                    pos2 = _rand.Next(0, 39);
                }
                if (map[pos1, pos2] ==(int)TypePoint.EmptySpace)
                {
                    map[pos1, pos2] = (int)TypePoint.Planet;
                }
            }
        }
        private void SeedPlayer()
        {
            int pos1 = _rand.Next(0, 39);
            int pos2 = _rand.Next(0, 39);
            while (map[pos1, pos2] == (int)TypePoint.StartPosition)
            {
                pos1 = _rand.Next(0, 39);
                pos2 = _rand.Next(0, 39);
            }
            if (map[pos1, pos2] == (int)TypePoint.EmptySpace)
            {
                map[pos1, pos2] = (int)TypePoint.StartPosition;
            }
            _startX = pos1;
            _startY = pos2;
        }

        private void ConfigureMapSize(Form currentForm)
        {
            currentForm.Width = _mapSize * _cellSize + 20;
            currentForm.Height = (_mapSize + 1) * _cellSize;
        }
        private void InitDefaultMap()
        {
            for (var i = 0; i < _mapSize; i++)
            {
                for (var j = 0; j < _mapSize; j++)
                {
                    map[i, j] = (int)TypePoint.EmptySpace;
                }
            }
        }

        private void InitMap(Form currentForm)
        {
            for (var i = 0; i < _mapSize; i++)
            {
                for (var j = 0; j < _mapSize; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(j * _cellSize, i * _cellSize);
                    button.Size = new Size(_cellSize, _cellSize);
                    button.BackColor = Color.White;
                    if (map[i, j] == (int)TypePoint.Planet)
                    {
                        button.Image = Properties.Resources.Planet;
                        _planetButton = button;

                    }
                    if (map[i, j] == (int)TypePoint.StartPosition)
                    {

                        button.Image = Properties.Resources.PlayerShip;
                        _heroButton = button;

                    }
                    else if (map[i, j] == (int)TypePoint.Station)
                    {
                        button.Image = Properties.Resources.CosmicStation;
                    }
                    button.Click += MoveShip_Click;
                    currentForm.Controls.Add(button);
                    _arrayButtons[i, j] = button;

                }
            }
            SetNameButton();
        }
        private void ClearArray()
        {
            for(int i=0;i<_mapSize;i++)
                for(int j=0;j<_mapSize;j++)
                {
                    if(map[i,j]>0)
                    {
                        map[i, j] = (int)TypePoint.EmptySpace;
                    }
                }
        }
        private void ClearPlanet()
        {
            for (int i = 0; i < _mapSize; i++)
                for (int j = 0; j < _mapSize; j++)
                {
                    if (map[i, j] == (int)TypePoint.Planet) 
                    { 
                   
                        _arrayButtons[i, j].Image = null;
                        map[i, j] = (int)TypePoint.EmptySpace;
                    }
                }
        }
        private void MoveShip_Click(object sender, EventArgs e)
        {
            if (Ship.comand.isBuy && Ship.aKB.isBuy && Ship.cannon.isBuy && Ship.collector.isBuy && Ship.corpus.isBuy && Ship.engine.isBuy && Ship.store.isBuy)
            {            
                string name = (sender as Button).Name;
                GetCoordinat(name);
                if (map[_endPointX, _endPointY] == (int)TypePoint.EmptySpace)
                {
                    Move(sender);
                }
                else
                {
                    if (map[_endPointX, _endPointY] == (int)TypePoint.Planet || map[_endPointX, _endPointY] == (int)TypePoint.Station)
                    {
                        if (map[_endPointX, _endPointY] == (int)TypePoint.Station)
                        {
                            ShopStation shop = new ShopStation();
                            Console.WriteLine("В следующем обновлении!");
                        }
                        else
                        {
                            Move(sender);
                            Ship.collector.CollectMineral();
                            CombatProcessor combatProcessor = new CombatProcessor();
                            combatProcessor.Combat();
                            GeneratePlanet();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Для того, чтобы корабль мог считаться готовым для полетов, он должен иметь следующие модули:Командный центр, Аккумулятор, Хранилище, Пушка, Сборщик, Корпус и Двигатель.");
            }
            
        }
        private void GeneratePlanet()
        {
            ClearPlanet();
            SeedPlanet();
            for(int i=0;i<_mapSize;i++)
                for(int j=0;j<_mapSize;j++)
                {
                    {
                        if (map[i, j] == (int)TypePoint.Planet)
                        {
                            _arrayButtons[i,j].Image = Properties.Resources.Planet;
                        }
                    }
            }
        }
        private void Move(object sender)
        {
            int countPoint = CalculateCoordinates();
            if (Ship.engine.EnergyConsumpMap(countPoint))
            {
                Resourse.Energy -= (Ship.engine.EnergyConsMap*countPoint);
                map[_startX, _startY] = (int)TypePoint.EmptySpace;
                map[_startX, _startY] = map[_endPointX, _endPointY];
                _startX = _endPointX;
                _startY = _endPointY;
                map[_endPointX, _endPointY] = (int)TypePoint.EmptySpace;
                ClearArray();
                _heroButton.Image = null;
                Button button = (sender as Button);
                button.Image = Properties.Resources.PlayerShip;
                _heroButton = button;
            }
        }
        private int CalculateCoordinates()
        {
            map[_startX, _startY] = (int)TypePoint.StartPosition;
            map[_endPointX, _endPointY] = (int)TypePoint.Destination;
            LeeAlgorithm li = new LeeAlgorithm(_startX,_startY,map);
            Console.WriteLine(li.PathFound);
            if (li.PathFound)
            {
                foreach (var item in li.Path)
                {
                    if (item == li.Path.Last())
                        map[item.Item1, item.Item2] = (int)TypePoint.StartPosition;
                    else if (item == li.Path.First())
                        map[item.Item1, item.Item2] = (int)TypePoint.Destination;
                    else
                        map[item.Item1, item.Item2] = (int)TypePoint.Path;
                }
                return (li.LengthPath - 1);
            }
            else
            {

                return 0;
            }
           


        }
        private void SetNameButton()
        {
            int inc = 1;
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                    _arrayButtons[i, j].Name = inc.ToString();
                    inc++;
                }

            }
        }
        private void GetCoordinat(string name)
        {
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                    if (_arrayButtons[i, j].Name == name)
                    {
                        _endPointX = i;
                        _endPointY = j;

                    }
                }
            }
        }
    }
}
