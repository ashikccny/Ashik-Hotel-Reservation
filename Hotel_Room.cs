//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ashik_Hotel_Reservation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hotel_Room
    {
        public int Hotel_Room_ID { get; set; }
        public Nullable<int> Hotel_ID { get; set; }
        public Nullable<int> No_of_room { get; set; }
        public Nullable<decimal> Room_Price { get; set; }
        public Nullable<int> RoomType_ID { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        public virtual RoomType RoomType { get; set; }
    }
}