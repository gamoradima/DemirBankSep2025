namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b5d97a23-23fa-4776-b51a-e9e1baa2a4c5");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8523031b-5509-4850-9d25-2cd5bb1d5c34");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,111,107,219,48,16,198,223,23,250,29,14,191,178,33,136,245,237,218,21,150,144,141,66,217,70,227,12,198,216,11,69,190,56,42,250,99,116,114,218,108,236,187,239,100,37,109,234,116,208,35,16,235,244,232,119,247,28,231,164,69,234,164,66,168,49,4,73,126,29,197,204,187,181,110,251,32,163,246,238,252,236,207,249,25,112,244,164,93,11,139,29,69,180,151,199,169,227,135,214,122,247,223,203,128,98,238,162,142,26,233,45,26,49,223,162,139,7,233,207,33,189,27,114,183,154,155,112,24,202,133,218,160,149,95,216,3,124,128,98,73,225,135,84,155,88,84,191,242,155,174,95,25,173,64,25,73,4,195,213,43,16,120,15,83,73,248,202,77,134,236,237,31,241,252,150,27,214,13,194,214,235,6,190,186,133,220,178,141,210,175,238,81,69,32,116,13,134,9,100,224,20,215,236,105,192,126,12,45,1,86,207,184,35,114,138,21,119,33,158,104,7,12,86,151,47,101,153,11,187,100,135,93,151,249,92,101,253,72,219,160,210,86,26,232,130,86,105,68,195,35,241,25,99,189,235,176,153,121,211,91,247,93,154,30,175,246,202,235,50,77,241,91,146,23,227,194,122,13,101,6,93,195,197,187,20,213,75,193,200,79,10,20,55,52,147,78,161,193,134,235,199,208,35,83,79,117,20,67,218,4,222,69,146,45,214,104,59,35,99,234,216,225,3,220,122,37,141,254,45,87,6,23,131,174,204,62,150,132,129,119,213,241,212,121,81,197,29,146,239,131,98,141,15,12,153,156,86,73,241,180,37,121,187,138,9,20,39,124,18,195,80,110,168,246,126,170,219,124,42,42,81,251,125,253,234,13,38,184,249,156,16,159,124,176,50,150,35,115,92,152,167,8,60,70,152,47,239,78,166,157,34,110,130,127,24,70,48,127,84,216,37,151,7,202,88,254,247,249,184,255,228,63,254,253,3,119,76,151,230,224,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3763b527-25c2-c279-f0c4-7a97db3dae8f"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("8523031b-5509-4850-9d25-2cd5bb1d5c34"),
				CreatedInSchemaUId = new Guid("b5d97a23-23fa-4776-b51a-e9e1baa2a4c5"),
				ModifiedInSchemaUId = new Guid("b5d97a23-23fa-4776-b51a-e9e1baa2a4c5")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5d97a23-23fa-4776-b51a-e9e1baa2a4c5"));
		}

		#endregion

	}

	#endregion

}

