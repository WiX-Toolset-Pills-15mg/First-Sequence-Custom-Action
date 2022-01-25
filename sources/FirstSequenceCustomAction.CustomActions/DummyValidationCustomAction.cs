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
    // ====================================================================================================
    // Step 1: Create the custom actions project
    // ====================================================================================================
    // 
    // A custom action project is a class library with additional instructions that creates the *.CA.dll
    // file as a wrapper over the normal .NET dll assembly.
    // This is necessary because Windows Installer is not able to consume .NET assemblies directly. This
    // *.CA.dll acts as an adapter.
    // 
    // Note: Because of this, make sure to always create a project of type "C# Custom Action Project for
    //       WiX v3" and not a normal class library project.
    // 
    // NEXT: DummyValidationCustomAction.cs

    public class DummyValidationCustomAction
    {
        // ====================================================================================================
        // Step 2: Implement the custom action
        // ====================================================================================================
        // 
        // Create a public static method having the [CustomAction] attribute on it. It will be, later,
        // referenced in the custom action tag from WiX.
        // 
        // The name of the custom action can be provider as parameter. In this case, it is "DummyValidation".
        // If it is not provided explicitly, it will be the name of the function: "Execute".
        // 
        // NEXT: CustomActions.wxs

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