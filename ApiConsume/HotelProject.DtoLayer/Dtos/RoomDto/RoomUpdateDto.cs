﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomID {  get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını giriniz!")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görselini giriniz!")]
        public string RoomCoverImg { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz!")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda başlığı bilgisini giriniz!")]
        [StringLength(100,ErrorMessage ="Lütfen en fazla 100 karakter veri girişi yapınız.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisi giriniz!")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı bilgisi giriniz!")]
        public string BathCount { get; set; }
        [Required(ErrorMessage = "Lütfen wifi bilgisi giriniz!")]
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen açıklama bilgisini giriniz!")]
        public string Description { get; set; }
    }
}
