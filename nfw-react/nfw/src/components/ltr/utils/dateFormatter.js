export const formatDate = (value, toTimeForCurrentDay = true) => {
  const date = new Date(value);
  if (isNaN(date.getTime())) { // Check if the date is invalid
    return ;
  }

  let newTime;
  const timeOptions = { year: 'numeric', month: 'long', day: 'numeric' }; // Removed 'weekday'

  const zeroPad = (num, places) => String(num).padStart(places, '0');

  const year = date.getFullYear().toString().substr(-2);
  const month = zeroPad(date.getMonth() + 1, 2);
  const day = zeroPad(date.getDate(), 2);

  const timeFormat = new Intl.DateTimeFormat('tr-TR', timeOptions).format(date);
  newTime = `${timeFormat}`;

  return newTime;
};
