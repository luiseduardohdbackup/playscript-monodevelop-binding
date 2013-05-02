﻿// 
// RedundantObjectOrCollectionInitializerIssue.cs
// 
// Author:
//      Mansheng Yang <lightyang0@gmail.com>
// 
// Copyright (c) 2012 Mansheng Yang <lightyang0@gmail.com>
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Collections.Generic;

namespace ICSharpCode.NRefactory.PlayScript.Refactoring
{
	[IssueDescription ("Redundant empty object or collection initializer",
					   Description = "Redundant empty object or collection initializer.",
					   Category = IssueCategories.Redundancies,
					   Severity = Severity.Suggestion,
					   IssueMarker = IssueMarker.GrayOut)]
	public class RedundantObjectOrCollectionInitializerIssue : ICodeIssueProvider
	{
		public IEnumerable<CodeIssue> GetIssues (BaseRefactoringContext context)
		{
			return new GatherVisitor (context).GetIssues ();
		}

		class GatherVisitor : GatherVisitorBase
		{
			public GatherVisitor (BaseRefactoringContext ctx)
				: base (ctx)
			{
			}

			public override void VisitObjectCreateExpression (ObjectCreateExpression objectCreateExpression)
			{
				base.VisitObjectCreateExpression (objectCreateExpression);
				if (objectCreateExpression.Initializer.IsNull || objectCreateExpression.Initializer.Elements.Count > 0)
					return;

				AddIssue (objectCreateExpression.Initializer, ctx.TranslateString ("Remove redundant empty initializer"),
					script => {
						var expr = (ObjectCreateExpression)objectCreateExpression.Clone ();
						expr.Initializer = ArrayInitializerExpression.Null;
						script.Replace (objectCreateExpression, expr);
					});
			}
		}
	}
}
