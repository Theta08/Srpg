using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class CSVReader
{
	static string SPLIT_RE = @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))";
	static string LINE_SPLIT_RE = @"\r\n|\n\r|\n|\r";
	static char[] TRIM_CHARS = { '\"' };

	public static List<Dictionary<string, object>> Read(string file)
	{
		// TODO json 형태 수정해야함
		// CharacterStat와 같은 형태로 나와야함 Dictionary로 list 묶어야함
		// Test.csv로 테스트 다시 해야함
		var list = new List<Dictionary<string, object>>();
		TextAsset data = Resources.Load (file) as TextAsset;

		var lines = Regex.Split (data.text, LINE_SPLIT_RE);

		if(lines.Length <= 1) return list;

		var header = Regex.Split(lines[0], SPLIT_RE);
		for(var i = 1; i < lines.Length - 1; i++) {	// 마지막이 공백을 포함시켜 -1 함

			var values = Regex.Split(lines[i], SPLIT_RE);
			// if(values.Length == 0 ||string.IsNullOrEmpty(values[0])) continue;

			var entry = new Dictionary<string, object>();
			
			for(var j = 0; j < header.Length && j < values.Length; j++ ) {
				
				if(header[j] == "") continue;
				
				string value = values[j];
				value = value.TrimStart(TRIM_CHARS).TrimEnd(TRIM_CHARS).Replace("\\", "");
				object finalvalue = value;
				int n;
				float f;
				if(int.TryParse(value, out n)) {
					finalvalue = n;
				} else if (float.TryParse(value, out f)) {
					finalvalue = f;
				}
				entry[header[j]] = finalvalue;
			}
			list.Add (entry);
		}
		return list;
	}
}
