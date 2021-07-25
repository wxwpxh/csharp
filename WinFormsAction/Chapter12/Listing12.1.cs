
    private void comboPhotographer_TextChanged(object sender, EventArgs e)
    {
      // See if a matching string exists in the list
      string text = comboPhotographer.Text;
      int index = -1;
      if (text.Length > 0)
        index = comboPhotographer.FindString(text);

      // Show list box only if a match was found
      if (index < 0)
        comboPhotographer.DroppedDown = false;
      else
      {
        comboPhotographer.DroppedDown = true;

        // Display and select remaining portion of matched entry
        string newText = comboPhotographer.Items[index].ToString();
        comboPhotographer.Text = newText;
        comboPhotographer.SelectionStart = text.Length;
        comboPhotographer.SelectionLength = newText.Length - text.Length;
      }
    }