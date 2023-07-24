/*
    Resets the order on warp
    Copyright (C) 2023 FloppyDisk
    https://github.com/flpydsk/OrderFix.git

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/
using PulsarModLoader;

namespace OrderFix
{
    public class Mod : PulsarMod
    {
        public override string License => "GNU GPL-3.0";
        public override string Version => "0.0.1";
        public override string Author => "FloppyDisk";
        public override string Name => "OrderFix";
        public override string HarmonyIdentifier() => $"{Author}.{Name}";
        public override string ShortDescription => "Resets the order on warp";
        public override string ReadmeURL => "https://raw.githubusercontent.com/flpydsk/OrderFix/master/README";
    }
}