﻿using System;
using UnityEngine;

namespace BrokenVector.FastGrid.Utils {
  public class Base64 {
    public enum TextureEncoding {
      JPG,
      PNG,
    }

    public static string ToBase64(Texture2D texture, TextureEncoding encoding) {
      byte[] bytes;
      switch (encoding) {
        case TextureEncoding.JPG:
          bytes = texture.EncodeToJPG();
          break;
        default:
        case TextureEncoding.PNG:
          bytes = texture.EncodeToPNG();
          break;
      }

      return Convert.ToBase64String(bytes);
    }

    public static Texture2D FromBase64(string base64) {
      var bytes = Convert.FromBase64String(base64);
      var tex = new Texture2D(2, 2);
      tex.LoadImage(bytes);
      return tex;
    }
  }
}