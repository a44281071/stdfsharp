/**
 * This file is part of StdfShap library
 *
 * This library is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Nome-Programma.  If not, see <http://www.gnu.org/licenses/>
 */

using System;
using System.IO;
using NUnit.Framework;

namespace KA.StdfSharp.Tests
{
    class Constants
    {
        static Constants()
        {
            var stdfDirectory = Directory.CreateDirectory(Path.Combine(Environment.GetEnvironmentVariable("TEMP"), "stdf"));
            TestStdfFilePath = Path.Combine(stdfDirectory.FullName, "stdf_test.std");
            TemporaryTestStdfFilePath = Path.Combine(stdfDirectory.FullName, "tmp.std");
        }

        public static readonly string TestStdfFilePath;
        public static readonly string TemporaryTestStdfFilePath;
    }
}