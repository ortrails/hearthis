// --------------------------------------------------------------------------------------------
#region // Copyright (c) 2014, SIL International. All Rights Reserved.
// <copyright from='2011' to='2014' company='SIL International'>
//		Copyright (c) 2014, SIL International. All Rights Reserved.
//
//		Distributable under the terms of the MIT License (http://sil.mit-license.org/)
// </copyright>
#endregion
// --------------------------------------------------------------------------------------------
using SIL.Progress;

namespace HearThis.Publishing
{
	public interface IPublishingMethod
	{
		void DeleteExistingPublishedFiles(string rootFolderPath, string bookName);
		string GetFilePathWithoutExtension(string rootFolderPath, string bookName, int chapterNumber);
		string RootDirectoryName { get; }
		void PublishChapter(string rootPath, string bookName, int chapterNumber, string pathToIncomingChapterWav, IProgress progress);
	}
}
