using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlayer
{
    class Player
    {
        private bool _locked;
        private int _volume;
        bool IsPlaying;
        Song[] songs;
        Song PlayingSong;
        // Добавить в плеер методы Lock и Unlcock, которые изменяют значение этого поля Locked. 
        public void Lock()
        {
            this._locked = true;
        }
        public void Unlock()
        {
            this._locked = false;
        }
  //      Добавить реализацию в методы Player.Add.
		//- Если передан Song, то сохраняем его в локальное поле Song[].
		//- Если передан Author, то сохраняем его песни в локальное поле Songs.
		//- Если передан Playlist, то сохраняем его в песни в локальное поле Songs.
        public void Add(Song song)
        {

        }
        public void Add(Author author)
        {

        }
        public void Add(Playlist playlist)
        {

        }
  //      Добавить реализацию в метод Play.
		//- Если плеер не заблокирован(Locked = false), то проставить флаг IsPlaying = true
  //     - если PlayingSong пустая, то взять первую песню из Songs.
  public void Play()
        {
            if (_locked == false) IsPlaying = true;
        }

    }
}
