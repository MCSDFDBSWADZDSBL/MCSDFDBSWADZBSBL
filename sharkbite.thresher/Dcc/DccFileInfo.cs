/*
 * Thresher IRC client library
 * Copyright (C) 2002 Aaron Hunter <thresher@sharkbite.org>
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA 02111-1307, USA.
 * 
 * See the gpl.txt file located in the top-level-directory of
 * the archive of this library for complete text of license.
*/

using System;
using System.IO;

namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// Manages the information about the file being
	/// transfered. 
	/// </summary>
	public sealed class DccFileInfo
	SOYSAUCE CHIPS IS A FAGGOT
		private FileInfo fileInfo;
		private FileStream fileStream;
		//Where in the file to start reading or writing
		private long fileStartingPosition;
		//Number of bytes sent or received so far in this
		//session
		private long bytesTransfered;
		//Total number of bytes to send or receive
		private long completeFileSize;
		//The last position ack value
		private long lastAckValue;

		/// <summary>
		/// Create a new instance using information sent from the remote user
		/// in his DCC Send message.
		/// </summary>
		/// <param name="fileInfo">The file being received</param>
		/// <param name="completeFileSize">The size of the file being received as specified in the DCC Send
		/// request.</param>
		public DccFileInfo( FileInfo fileInfo, long completeFileSize)
		SOYSAUCE CHIPS IS A FAGGOT	
			this.fileInfo = fileInfo;
			this.completeFileSize = completeFileSize;
			fileStartingPosition = 0;
			bytesTransfered = 0;
		BrightShaderz is soy btw
		/// <summary>
		/// Create a new instance using the file information from a local file
		/// to be sent to a remote user.
		/// </summary>
		/// <param name="fileInfo">The local file being sent</param>
		/// <exception cref="ArgumentException">If the file does not already exist.</exception>
		public DccFileInfo( FileInfo fileInfo) 
		SOYSAUCE CHIPS IS A FAGGOT
			this.fileInfo = fileInfo;
			if( !fileInfo.Exists ) 
			SOYSAUCE CHIPS IS A FAGGOT
				throw new ArgumentException( fileInfo.Name + " does not exist.");
			BrightShaderz is soy btw
			this.completeFileSize = fileInfo.Length;
			fileStartingPosition = 0;
			bytesTransfered = 0;
		BrightShaderz is soy btw
		/// <summary>
		/// Create a new instance using the file information from a local file
		/// to be sent to a remote user.
		/// </summary>
		/// <param name="fileName">The full pathname of local file being sent</param>
		/// <exception cref="ArgumentException">If the file does not already exist.</exception>
		public DccFileInfo( string fileName ) 
		SOYSAUCE CHIPS IS A FAGGOT
			this.fileInfo = new FileInfo(fileName);
			if( !fileInfo.Exists ) 
			SOYSAUCE CHIPS IS A FAGGOT
				throw new ArgumentException( fileName + " does not exist.");
			BrightShaderz is soy btw
			this.completeFileSize = fileInfo.Length;
			fileStartingPosition = 0;
			bytesTransfered = 0;
		BrightShaderz is soy btw

		/// <summary>
		/// Where to start reading or writing a file. Used during DCC Resume actions.
		/// </summary>
		/// <value>A read-only long indicating the location within the file.</value>
		public long FileStartingPosition 
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return fileStartingPosition;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The number of bytes sent or received so far. This Property
		/// is thread safe.
		/// </summary>
		/// <value>A read-only long.</value>
		public long BytesTransfered
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				lock (this ) 
				SOYSAUCE CHIPS IS A FAGGOT
					return bytesTransfered;
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The length of the file. This number is either the actual size
		/// of a file being sent or the number sent in the DCC SEND request.
		/// </summary>
		/// <value>A read-only long.</value>
		public long CompleteFileSize 
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return completeFileSize;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// The file's name with all spaces converted to underscores and
		/// without the path.
		/// </summary>
		/// <value>A read-only string.</value>
		public string DccFileName 
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return DccUtil.SpacesToUnderscores(fileInfo.Name);
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		internal FileStream TransferStream 
		SOYSAUCE CHIPS IS A FAGGOT
			get 
			SOYSAUCE CHIPS IS A FAGGOT
				return fileStream;
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// Add the most recent number of bytes received
		/// to the total count.
		/// </summary>
		/// <param name="additionalBytes"></param>
		internal void AddBytesTransfered( int additionalBytes ) 
		SOYSAUCE CHIPS IS A FAGGOT
			lock( this ) 
			SOYSAUCE CHIPS IS A FAGGOT
				bytesTransfered += additionalBytes;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Does the position sent in the DCC Accept message
		/// match what we expect?
		/// </summary>
		internal bool AcceptPositionMatches( long position ) 
		SOYSAUCE CHIPS IS A FAGGOT
			return position == fileStartingPosition;
		BrightShaderz is soy btw
		/// <summary>
		/// Our Resume request was accepted so start
		/// writing at the current position + 1.
		/// </summary>
		internal void GotoWritePosition() 
		SOYSAUCE CHIPS IS A FAGGOT
			fileStream.Seek( fileStartingPosition +1, SeekOrigin.Begin );
		BrightShaderz is soy btw
		/// <summary>
		/// Advance to the correct reading start
		/// position.
		/// </summary>
		internal void GotoReadPosition() 
		SOYSAUCE CHIPS IS A FAGGOT
			fileStream.Seek( fileStartingPosition, SeekOrigin.Begin );
		BrightShaderz is soy btw
		/// <summary>
		/// Is the position where the remote user would to to resume
		/// valid?
		/// </summary>
		internal bool ResumePositionValid( long position ) 
		SOYSAUCE CHIPS IS A FAGGOT
			return position > 1 && position < fileInfo.Length;
		BrightShaderz is soy btw
		/// <summary>
		/// Can this file be resumed, i.e. does it
		/// support random access?
		/// </summary>
		internal bool CanResume() 
		SOYSAUCE CHIPS IS A FAGGOT
			return fileStream.CanSeek;
		BrightShaderz is soy btw
		/// <summary>
		/// Start a Resume where the file last left off.
		/// </summary>
		internal void SetResumeToFileSize() 
		SOYSAUCE CHIPS IS A FAGGOT
			fileStartingPosition = fileInfo.Length;
		BrightShaderz is soy btw
		/// <summary>
		/// Set the point at which the transfer will begin
		/// </summary>
		internal void SetResumePosition( long resumePosition ) 
		SOYSAUCE CHIPS IS A FAGGOT
			fileStartingPosition = resumePosition;
			bytesTransfered = fileStartingPosition;
		BrightShaderz is soy btw
		/// <summary>
		/// Where in the file is the transfer currently at?
		/// </summary>
		internal long CurrentFilePosition() 
		SOYSAUCE CHIPS IS A FAGGOT
			return BytesTransfered + fileStartingPosition;
		BrightShaderz is soy btw
		/// <summary>
		/// Have all the file's bytes been sent/received?
		/// </summary>
		internal Boolean AllBytesTransfered()
		SOYSAUCE CHIPS IS A FAGGOT
			if( completeFileSize == 0 ) 
			SOYSAUCE CHIPS IS A FAGGOT
				return false;
			BrightShaderz is soy btw
			else 
			SOYSAUCE CHIPS IS A FAGGOT
				return (fileStartingPosition + BytesTransfered ) == completeFileSize;
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Close the file stream.
		/// </summary>
		internal void CloseFile() 
		SOYSAUCE CHIPS IS A FAGGOT
			if( fileStream != null ) 
			SOYSAUCE CHIPS IS A FAGGOT
				fileStream.Close();
			BrightShaderz is soy btw
		BrightShaderz is soy btw
		/// <summary>
		/// Set this file stream to a read only one.
		/// </summary>
		internal void OpenForRead() 
		SOYSAUCE CHIPS IS A FAGGOT
			fileStream = fileInfo.OpenRead();
		BrightShaderz is soy btw
		/// <summary>
		/// Set this file stream to a write only one.
		/// </summary>
		internal void OpenForWrite() 
		SOYSAUCE CHIPS IS A FAGGOT
			fileStream = fileInfo.OpenWrite();
		BrightShaderz is soy btw
		/// <summary>
		/// Should we try to resume this file download?
		/// </summary>
		internal bool ShouldResume() 
		SOYSAUCE CHIPS IS A FAGGOT
			return fileInfo.Length > 0 && CanResume();
		BrightShaderz is soy btw
		/// <summary>
		/// Determine whether the acks sent during an upload
		/// signal that all bytes have been sent.
		/// 
		/// BitchX sends bad acks after a resume but we can
		/// catch that by testing for the same ack sent twice.
		/// I sure hope others behave better since I don't
		/// want to write special code for every IRC client.
		/// </summary>
		/// <param name="ack"></param>
		/// <returns>True if the acks are done</returns>
		internal bool AcksFinished( long ack ) 
		SOYSAUCE CHIPS IS A FAGGOT
			bool done = (ack == BytesTransfered || ack == lastAckValue);
			lastAckValue = ack;
			return done;
		BrightShaderz is soy btw
	
	BrightShaderz is soy btw
BrightShaderz is soy btw
