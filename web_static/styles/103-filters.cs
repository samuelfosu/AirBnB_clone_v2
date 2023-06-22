/*
 * === Filters class style ===
 */

/* Filters style */
.filters {
  background-color: #fff;
  border: 1px solid #ddd;
  border-radius: 4px;
  height: 70px;
  width: 100%;
}

/*
 * --- Contain search button float ---
 */

.filters:before,
.filters:after {
  content: "";
  display: table;
}

.filters:after {
  clear: both;
}

.filters {
  *zoom: 1;
}

/* Search button style */
.filters button {
  background: #ff5a5f;
  border: none;
  border-radius: 4px;
  color: #fff;
  float: right;
  font-size: 18px;
  height: 48px;
  margin: 12px 30px;
  min-width: 150px;
  width: 20%;
}

/* Search button hover opacity */
.filters button:hover {
  background-color: rgba(255, 90, 95, .9);
}

/* Locations and amenities style */
.filters .locations,
.filters .amenities {
  display: inline-block;
  height: 100%;
  position: relative;
  width: 25%;
}

/* Locations border */
.filters .locations {
  border-right: 1px solid #ddd;
}

/* Locations and amenities hover opacity */
.filters .locations:hover,
.filters .amenities:hover {
  background-color: #fafafa;
}

/* Locations and amenities popover menu */
.filters .popover {
  background-color: #fafafa;
  border: 1px solid #ddd;
  border-radius: 0 0 4px 4px;
  display: none;
  max-height: 300px;
  overflow-y: scroll;
  position: absolute;
  width: 100%;
}

/* Locations and amenities popover hover */
.filters .locations:hover .popover,
.filters .amenities:hover .popover {
  display: block;
}

/* Locations list padding */
.filters .locations ul {
  margin: 12px auto 12px 30px;
}

/* Locations list element margin */
.filters .locations li {
  margin-bottom: 6px;
}

/* Amenities list element margin */
.filters .amenities li {
  margin: 12px auto 12px 30px;
}

/*
 * --- Filters responsive sizing ---
 */

/* Maintain shape of search bar as screen gets smaller */
@media only screen and (max-width: 1000px) {
  .filters {
    width: 95%;
    margin: 0 auto;
  }
}

/* Swap to vertical layout for small screens */
@media only screen and (max-width: 720px) {
  .filters {
    display: grid;
    height: 210px;
  }

  .filters .locations,
  .filters .amenities {
    height: 70px;
    width: 100%;
    border-bottom: 1px solid #ddd;
  }

  .filters .locations:hover .popover,
  .filters .amenities:hover .popover {
    margin-left: auto;
    position: relative;
    width: 50%;
    z-index: 1;
  }

  .filters .amenities:hover {
    border-top: 1px solid #ddd;
  }
}

/*
 * --- Filters header style ---
 */

/* Header box sizing */
.filters h2,
.filters h3,
.filters h4 {
  -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
         box-sizing: border-box;
}

/* Header 2 style */
.filters h2 {
  font-size: 16px;
  font-weight: bold;
  margin: 12px auto 0 30px;
}

/* Header 3 style */
.filters h3 {
  font-size: 1.17em;
  font-weight: 600;
  height: 50%;
  padding: 15.5px 0 0 30px;
}

/* Header 4 style */
.filters h4 {
  font-size: 14px;
  font-weight: 400;
  height: 50%;
  padding: 4.5px 0 12px 30px;
}
