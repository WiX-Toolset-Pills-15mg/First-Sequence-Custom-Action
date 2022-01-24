// WiX Toolset Pills 15mg
// Copyright (C) 2019-2021 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using Microsoft.Deployment.WindowsInstaller;

namespace DustInTheWind.FirstSequenceCustomAction.CustomActions
{
    public class DummyValidationCustomAction
    {
        [CustomAction("DummyValidation")]
        public static ActionResult Execute(Session session)
        {
            session.Log("--> Begin DummyValidation");
            try
            {
                session.Log("Everything is alright. Thank you for asking.");

                return ActionResult.Success;
            }
            finally
            {
                session.Log("--> End DummyValidation");
            }
        }
    }
}