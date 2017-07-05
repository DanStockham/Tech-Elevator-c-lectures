# Instructor Notes

This lecture is currently built off of an in-class example that was used as a review topic for ASP.NET MVC. The review project built a 
very basic Add/Update/List view for a Recipe manager.

This day's example should raise the question: _If we always redirect our user back to the home page (list of recipes) after they add or edit, how would they know if their recipe was successfully added?_

The solution lies in using `TempData` immediately after the changes are saved to the database and relying on that `TempData` to display a message when necessary.