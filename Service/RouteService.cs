using ScratchRentMe.Model;
using System.Linq;
using System.Windows.Forms;

namespace ScratchRentMe.Service
{
    public static class RouteService
    {
        /*
        public void Go()
        {

        }
        */

        /// <summary>
        /// Hides the current form and displays the specified form and
        /// creates a new instance if the specified form is not already open.
        /// </summary>
        /// 
        /// <typeparam name="T">The type of form to be shown.</typeparam>
        /// <param name="callingForm">The form invoking this method, to be hidden.</param>
        /// <returns>The instance of the shown form.</returns>
        public static Form HideAndShowForm<T>(this Form callingForm) where T : Form, new()
        {
            var targetForm = Application.OpenForms.OfType<T>().FirstOrDefault() ?? new T();
            targetForm.Show();
            callingForm.Hide();
            return targetForm;
        }
    }
}
