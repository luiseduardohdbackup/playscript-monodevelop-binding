// 
// NRefactoryCodeIssueSource.cs
//  
// Author:
//       Mike Krüger <mkrueger@xamarin.com>
// 
// Copyright (c) 2012 Xamarin Inc. (http://xamarin.com)
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
using System;
using MonoDevelop.CodeIssues;
using System.Collections.Generic;

namespace MonoDevelop.PlayScript.Refactoring.CodeIssues
{
	public class NRefactoryCodeIssueSource : ICodeIssueProviderSource
	{
		#region ICodeIssueProviderSource implementation
		public IEnumerable<CodeIssueProvider> GetProviders ()
		{
			foreach (var t in typeof (ICSharpCode.NRefactory.PlayScript.Refactoring.ICodeIssueProvider).Assembly.GetTypes ()) {
				var attr = t.GetCustomAttributes (typeof(ICSharpCode.NRefactory.PlayScript.IssueDescriptionAttribute), false);
				if (attr == null || attr.Length != 1)
					continue;
				yield return new NRefactoryIssueProvider (
					(ICSharpCode.NRefactory.PlayScript.Refactoring.ICodeIssueProvider)Activator.CreateInstance (t),
					(ICSharpCode.NRefactory.PlayScript.IssueDescriptionAttribute)attr [0]);
			}
		}
		#endregion
	}
}
