﻿using System;
using OhioBox.Moranbernate.Mapping;

namespace OhioBox.Moranbernate.Tests.Domain
{
	public class SimpleObject
	{
		public long Id { get; set; }
		public long Long { get; set; }
		public string SomeString { get; set; }
		public long? NullableLong { get; set; }
		public Guid Guid { get; set; }
		public Guid? NullableGuid { get; set; }
		public IntBasedEnum IntBasedEnum { get; set; }
		public IntBasedEnum? NullableIntBasedEnum { get; set; }
	}

	public enum IntBasedEnum
	{
		SomeValue = 1,
		OtherValue = 2
	}

	public class SimpleObjectMap : ClassMap<SimpleObject>
	{
		public SimpleObjectMap()
		{
			Table("table_name");
			Id(x => x.Id).GeneratedBy.AutoGenerated();

			Map(x => x.Long, "LongColumnName");
			Map(x => x.SomeString);
			Map(x => x.NullableLong);
			Map(x => x.Guid);
			Map(x => x.NullableGuid);
			Map(x => x.IntBasedEnum);
			Map(x => x.NullableIntBasedEnum);
		}
	}
}