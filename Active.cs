﻿using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.DatabaseServices;

namespace EJ_.Utilities
{
		/// <summary>
		/// Provides easy access to several "active" objects in the AutoCAD
		/// runtime environment.
		/// </summary>
		public static class Active
		{
			/// <summary>
			/// Returns the active Editor object.
			/// </summary>
			public static Autodesk.AutoCAD.EditorInput.Editor Editor
			{
				get { return Document.Editor; }
			}

			/// <summary>
			/// Returns the active Document object.
			/// </summary>
            public static Autodesk.AutoCAD.ApplicationServices.Document Document
			{
				get { return Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument; }
			}

			/// <summary>
			/// Returns the active Database object.
			/// </summary>
			public static Database Database
			{
				get { return Document.Database; }
			}

			/// <summary>
			/// Sends a string to the command line in the active Editor
			/// </summary>
			/// <param name="message">The message to send.</param>
			public static void WriteMessage(string message)
			{
				Editor.WriteMessage(message);
			}

			/// <summary>
			/// Sends a string to the command line in the active Editor using String.Format.
			/// </summary>
			/// <param name="message">The message containing format specifications.</param>
			/// <param name="parameter">The variables to substitute into the format string.</param>
			public static void WriteMessage(string message, params object[] parameter)
			{
				Editor.WriteMessage(message, parameter);
			}
		}
}
