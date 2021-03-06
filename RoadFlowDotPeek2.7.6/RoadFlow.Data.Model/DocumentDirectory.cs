﻿// Decompiled with JetBrains decompiler
// Type: RoadFlow.Data.Model.DocumentDirectory
// Assembly: RoadFlow.Data.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B924143B-AEC1-4AFA-B627-1D84458A850C
// Assembly location: C:\inetpub\wwwroot\RoadFlowMvc\bin\RoadFlow.Data.Model.dll

using System;
using System.ComponentModel;

namespace RoadFlow.Data.Model
{
  [Serializable]
  public class DocumentDirectory
  {
    [DisplayName("ID")]
    public Guid ID { get; set; }

    [DisplayName("ParentID")]
    public Guid ParentID { get; set; }

    [DisplayName("Name")]
    public string Name { get; set; }

    [DisplayName("阅读人员")]
    public string ReadUsers { get; set; }

    [DisplayName("管理人员")]
    public string ManageUsers { get; set; }

    [DisplayName("发布人员")]
    public string PublishUsers { get; set; }

    [DisplayName("排序")]
    public int Sort { get; set; }
  }
}
