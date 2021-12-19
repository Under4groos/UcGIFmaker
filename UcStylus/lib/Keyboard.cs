﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcStylus.lib
{
    public static class Keyboard
    {
        [Flags]
        public enum KeyStates
        {
            None = 0,
            Down = 1,
            Toggled = 2
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern short GetKeyState(int keyCode);
        /// <summary>
        /// Получить текущий статус кнопки.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static KeyStates GetKeyState(Keys key)
        {
            KeyStates state = KeyStates.None;

            short retVal = GetKeyState((int)key);

            if ((retVal & 0x8000) == 0x8000)
                state |= KeyStates.Down;

            if ((retVal & 1) == 1)
                state |= KeyStates.Toggled;

            return state;
        }

        /// <summary>
        /// Клавиша нажата?
        /// </summary>
        public static bool IsKeyDown(System.Windows.Input.Key key)
        {
            return (int)KeyStates.Down == (GetKeyState((int)key) & (int)KeyStates.Down);
        }

        /// <summary>
        /// Клавиша отпущена?
        /// </summary>
        public static bool IsKeyToggled(Keys key)
        {
            return KeyStates.Toggled == (GetKeyState(key) & KeyStates.Toggled);
        }


    }
}
