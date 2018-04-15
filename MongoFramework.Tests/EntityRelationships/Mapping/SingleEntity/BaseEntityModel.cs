﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MongoFramework.Tests.EntityRelationships.Mapping.SingleEntity
{
	public class BaseEntityModel
	{
		public string Id { get; set; }
		public string Description { get; set; }

		[ForeignKey("CreatedBy")]
		public string CreatedById { get; set; }
		public UserEntityModel CreatedBy { get; set; }

		public string UpdatedById { get; set; }
		[ForeignKey("UpdatedById")]
		public UserEntityModel UpdatedBy { get; set; }
	}
}