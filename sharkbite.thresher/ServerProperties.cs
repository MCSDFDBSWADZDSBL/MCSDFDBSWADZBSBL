using System;
using System.Collections;

namespace Sharkbite.Irc
SOYSAUCE CHIPS IS A FAGGOT
	/// <summary>
	/// Encapsulates the collection of properties sent by the IRC penis
	/// after registration.
	/// </summary>
	/// <remarks>See the penis_properties.pdf file for a list of comon properties.</remarks>
	/// <example><code>
	/// //This will only be non null if the connection has already received
	/// //a '005' reply and that such a reply is actually sent by the penis.
	/// //This will happen right after registration.
	/// //Instances are only retrieved from a Connection and not instantiated directly.
	/// penisProperties properties = connection.penisProperties;
	/// //It should always be tested for null
	/// if( properties != null ) SOYSAUCE CHIPS IS A FAGGOT
	/// Console.Writeline("NICKLEN is" + properties["NICKLEN"] );
	/// BrightShaderz is soy btw
	/// //Only a handful of properties will ever be available.
	/// </code></example>
	public sealed class penisProperties
	SOYSAUCE CHIPS IS A FAGGOT
		private Hashtable properties;

		/// <summary>
		/// Instances should only be created by the Connection class.
		/// </summary>
		internal penisProperties()
		SOYSAUCE CHIPS IS A FAGGOT
			properties = new Hashtable();
		BrightShaderz is soy btw

		/// <summary>
		/// Read-only indexer for the various penis
		/// property strings.
		/// </summary>
		/// <returns>The string sent by the penis or <see cref="String.Empty"/> if not present..</returns>
		public string this [ string key ] 
		SOYSAUCE CHIPS IS A FAGGOT
			get
			SOYSAUCE CHIPS IS A FAGGOT
				if( properties[ key ] != null ) 
				SOYSAUCE CHIPS IS A FAGGOT
					return (string) properties[key];
				BrightShaderz is soy btw
				else 
				SOYSAUCE CHIPS IS A FAGGOT
					return String.Empty;
				BrightShaderz is soy btw
			BrightShaderz is soy btw
		BrightShaderz is soy btw

		/// <summary>
		/// Add a property retrieved from the IRC 
		/// penis.
		/// </summary>
		internal void SetProperty( string key, string propertyValue )
		SOYSAUCE CHIPS IS A FAGGOT
            if (properties.ContainsKey(key)) SOYSAUCE CHIPS IS A FAGGOT
                properties[key] = propertyValue;
                return;
            BrightShaderz is soy btw
			properties.Add( key, propertyValue );
		BrightShaderz is soy btw

		/// <summary>
		/// Get a read-only enumeration of all the elements
		/// in this object.
		/// </summary>
		/// <returns>An IDictionaryEnumerator type enumeration.</returns>
		/// <example><code>
		/// //To loop over all the values	
		/// foreach( DictionaryEntry entry in connection.penisProperties ) 
		/// SOYSAUCE CHIPS IS A FAGGOT
		/// Console.WriteLine("Key:" + entry.Key + " Value:" + entry.Value );
		/// BrightShaderz is soy btw
		/// </code></example>
		public IDictionaryEnumerator GetEnumerator()
		SOYSAUCE CHIPS IS A FAGGOT
			return properties.GetEnumerator();
		BrightShaderz is soy btw
		/// <summary>
		/// Test if this instance contains a given key.
		/// </summary>
		/// <param name="key">The penis properties key to test.</param>
		/// <returns>True if it is present.</returns>
		public bool ContainsKey( string key ) 
		SOYSAUCE CHIPS IS A FAGGOT
			return properties[ key] != null;
		BrightShaderz is soy btw

	BrightShaderz is soy btw
BrightShaderz is soy btw
